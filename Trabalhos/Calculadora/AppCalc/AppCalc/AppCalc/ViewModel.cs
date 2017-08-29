using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppCalc
{
    public enum Operacao
    {
        Soma,
        Subtracao,
        Multiplicacao,
        Divisao
    }

    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Operacao? oper;
        private int n1;
        private int n2;

        private int? visor;

        public int? Visor
        {
            get { return visor; }
            set
            {
                visor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Visor)));
            }
        }

        public ICommand RealizaOperacaoCommand { get; }
        public ICommand InsereNumeroCommand { get; }
        public ICommand LimpaTudoCommand { get; }
        public ICommand InsereOperacaoCommand { get; }

        public ViewModel()
        {
            n1 = 0;
            n2 = 0;

            InsereNumeroCommand = new Command<string>(InsereNumero);
            LimpaTudoCommand = new Command(LimpaTudo);
            InsereOperacaoCommand = new Command<string>(InsereOperacao);
            RealizaOperacaoCommand = new Command(RealizaOperacao);
        }

        private void InsereNumero(string numeroInserido)
        {
            if (oper == null)
            {
                n1 = n1 * 10 + Convert.ToInt32(numeroInserido);
                Visor = n1;
            }
            else
            {
                n2 = n2 * 10 + Convert.ToInt32(numeroInserido);
                Visor = n2;
            }
        }

        private void LimpaTudo()
        {
            n1 = 0;
            n2 = 0;
            oper = null;
            Visor = null;
        }

        private void InsereOperacao(string operacao)
        {
            if (operacao == "+")
                oper = Operacao.Soma;
            if (operacao == "-")
                oper = Operacao.Subtracao;
            if (operacao == "*")
                oper = Operacao.Multiplicacao;
            if (operacao == "/")
                oper = Operacao.Divisao;
        }

        private void RealizaOperacao()
        {
            switch (oper)
            {
                case Operacao.Soma:
                    n1 = n1 + n2;
                    break;
                case Operacao.Subtracao:
                    n1 = n1 - n2;
                    break;
                case Operacao.Multiplicacao:
                    n1 = n1 * n2;
                    break;
                case Operacao.Divisao:
                    try
                    {
                        n1 = n1 / n2;
                    }
                    catch
                    {
                        n1 = 0;
                    }
                    break;
                case null:
                    return;
            }

            Visor = n1;
            n2 = 0;
            oper = null;
        }
    }
}
