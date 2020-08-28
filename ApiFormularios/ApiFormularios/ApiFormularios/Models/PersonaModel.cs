using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace ApiFormularios.Models
{
    public class PersonaModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }

        private bool isBusy = false;

        public bool IsBusy
        { 

        get { return isBusy = false;}
                set {isBusy =  value;

                OnPropertyChanged();
                
            }
                }

        private string id;

        public string Id
        {
            get { return id; }
            set {
                id = value;
                OnPropertyChanged();


            }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));


            }

        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value;

                OnPropertyChanged();
                OnPropertyChanged(nameof(NombreCompleto));

            }
        }

        private string contacto;

        public string Contacto
        {
            get { return contacto; }
            set { contacto = value; 
            OnPropertyChanged();
                }

    }

        private string nombreCompleto;

        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }

            set { nombreCompleto = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Mensaje));

            }
        }

        private string Mensaje;

       

        public string mensaje
        {
            get { return $"Tu nombre es {NombreCompleto}";
            }
           
            }

        }
    }


