using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM.ViewModels
{
    public class OperationsViewModel : ViewModelBase
    {
        // Comentario de prueba
        #region Propiedades
        int valor1;
        public int Valor1
        {
            get { return valor1;  }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }

            }
        }

        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }

            }
        }

        int suma;
        public int ResultSuma
        {
            get { return suma; }
            set
            {
                if (suma != value)
                {
                    suma = value;
                    OnPropertyChanged();
                }

            }
        }

        int resta;
        public int ResultResta
        {
            get { return resta; }
            set
            {
                if (resta != value)
                {
                    resta = value;
                    OnPropertyChanged();
                }

            }
        }

        int producto;
        public int ResultProducto
        {
            get { return producto; }
            set
            {
                if (producto != value)
                {
                    producto = value;
                    OnPropertyChanged();
                }

            }
        }

        int division;
        public int ResultDivision
        {
            get { return division; }
            set
            {
                if (division != value)
                {
                    division = value;
                    OnPropertyChanged();
                }

            }
        }
        #endregion

        #region Comandos
        public ICommand Sumar { protected set; get; }
        public ICommand Restar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }
        public ICommand Dividir { protected set; get; }

        #endregion

        #region Constructor
        public OperationsViewModel()
        {
            Sumar = new Command(() =>
            {
                ResultSuma = Valor1 + Valor2;
            });
            
            Restar = new Command(() =>
            {
                ResultResta = Valor1 - Valor2;
            });

            Multiplicar = new Command(() =>
            {
                ResultProducto = Valor1 * Valor2;
            });

            Dividir = new Command(() =>
            {
                if (Valor2 < 1)
                {
                    Valor2 = 1;
                }
                
                ResultDivision = Valor1 / Valor2;
            });
        }
        #endregion
    }
}