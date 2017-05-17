using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Syncfusion.SfChart.XForms;

namespace MyAttemptX.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistogramPage : ContentPage
    {
        public HistogramPage()
        {
            InitializeComponent();
            //BindingContext = new HistogramViewModel();

            SfChart chart = new SfChart();

            //Initializing Primary Axis
            CategoryAxis primaryAxis = new CategoryAxis();

            chart.PrimaryAxis = primaryAxis;

            //Initializing Secondary Axis
            NumericalAxis secondaryAxis = new NumericalAxis();

            chart.SecondaryAxis = secondaryAxis;

            this.Content = chart;
        }
    }

    class HistogramViewModel : INotifyPropertyChanged
    {

        public HistogramViewModel()
        {
            IncreaseCountCommand = new Command(IncreaseCount);
        }

        int count;

        string countDisplay = "You clicked 0 times.";
        public string CountDisplay
        {
            get { return countDisplay; }
            set { countDisplay = value; OnPropertyChanged(); }
        }

        public ICommand IncreaseCountCommand { get; }

        void IncreaseCount() =>
            CountDisplay = $"You clicked {++count} times";


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName]string propertyName = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}