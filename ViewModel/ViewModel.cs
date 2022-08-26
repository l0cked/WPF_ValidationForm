namespace WPF_ValidationForm.ViewModel
{
    internal partial class ViewModel
    {
        private string name;
        public string Name { get => name; set => Set(ref name, value); }

        private int? age = null;
        public int? Age { get => age; set => Set(ref age, value); }
    }
}
