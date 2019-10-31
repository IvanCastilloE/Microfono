using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using NAudio;
using NAudio.Wave;
using NAudio.Dsp;

namespace Microfono
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WaveIn waveIn; //Conecta con el microfono
        WaveFormat formato; //formato de audio

        public MainWindow()
        {

            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, RoutedEventArgs e)
        {
            //Inicializar la conexion
            waveIn = new WaveIn();
            //Establecer el formato (F. muestreo, profundidad de bits, No. canales)
            waveIn.WaveFormat = new WaveFormat(44100, 16, 1);
            formato = waveIn.WaveFormat;

            //Duracion del buffer
            waveIn.BufferMilliseconds = 500;

            //Con que funcion respondemos cuando se llena el buffer
            waveIn.DataAvailable += WaveIn_DataAvailable;

            waveIn.StartRecording();
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
