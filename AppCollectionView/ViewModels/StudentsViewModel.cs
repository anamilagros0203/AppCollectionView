using AppCollectionView.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace AppCollectionView.ViewModels
{
    public class StudentsViewModel
    {
        public ObservableCollection<Students> students { get; set; }

        public StudentsViewModel()
        {
            students = new ObservableCollection<Students>
            {
                new Students{Name="Maria",LastName="Rojas", Telephone="(01) 999 999 998", Image="mujer.png"},
                new Students{Name="Jose",LastName="Rojas", Telephone="(01) 999 999 999", Image="hombre.png"},
                new Students{Name="Carlos",LastName="Rojas", Telephone="(01) 999 999 999",Image="hombre.png"},
                new Students{Name="Mario",LastName="Rojas", Telephone="(01) 999 999 999",Image="hombre.png"},
                new Students{Name="Roberto",LastName="Rojas", Telephone="(01) 999 999 999",Image="hombre.png"},
                new Students{Name="Gloria",LastName="Rojas", Telephone="(01) 999 999 999",Image="mujer.png"},
                new Students{Name="Rosario",LastName="Rojas", Telephone="(01) 999 999 999",Image="mujer.png"},
                new Students{Name="Liliana",LastName="Rojas", Telephone="(01) 999 999 999",Image="mujer.png"},
                new Students{Name="Guisella",LastName="Rojas", Telephone="(01) 999 999 999",Image="mujer.png"},
                new Students{Name="Yessica",LastName="Rojas", Telephone="(01) 999 999 999",Image="mujer.png"},
                new Students{Name="Luis",LastName="Rojas", Telephone="(01) 999 999 999",Image="hombre.png"},
            };
        }
    }
}
