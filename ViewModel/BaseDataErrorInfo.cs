using System.ComponentModel;

namespace WPF_ValidationForm.ViewModel
{
    internal partial class ViewModel : IDataErrorInfo
    {
        public string this[string columnName]
        {
            get
            {
                var err = string.Empty;

                switch (columnName)
                {
                    case "Name":
                        if (string.IsNullOrEmpty(Name)) err = "Имя не может быть пустым";
                        break;
                    case "Age":
                        if (Age == null) err = "Возраст не может быть пустым";
                        if (Age == 0) err = "Возраст не может быть нулем";
                        if (Age < 0) err = "Возраст не может быть меньше нуля";
                        if (Age > 150) err = "Возраст не может быть больше 150";
                        break;
                }

                return err;
            }
        }

        public string Error => throw new System.NotImplementedException();
    }
}
