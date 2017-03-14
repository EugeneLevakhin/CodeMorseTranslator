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

using Microsoft.Win32;
using System.IO;

namespace CodeMorseTranslator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool isTextChanged = false;
        string fileNameForSaving = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonTranslate_Click(object sender, RoutedEventArgs e)
        {
            statusBlock.Text = "Translating...";
            MorseTranslator translator = new MorseTranslator();
            if (lstDirectionOfTranslate.SelectedItem == lstDirectionOfTranslate.Items[0])
            {
                Task<string> task = translator.TransleteEnglishToCodeAsync(txtSource.Text);
                task.ContinueWith(t =>
                this.Dispatcher.Invoke(() => { txtTarget.Text = t.Result; statusBlock.Text = string.Empty; })
                );
            }
            else if (lstDirectionOfTranslate.SelectedItem == lstDirectionOfTranslate.Items[1])
            {
                Task<string> task = translator.TransleteCodeToEnglishAsync(txtSource.Text);
                task.ContinueWith(t =>
                this.Dispatcher.Invoke(() => { txtTarget.Text = t.Result; statusBlock.Text = string.Empty; })
                );
            }
            else if (lstDirectionOfTranslate.SelectedItem == lstDirectionOfTranslate.Items[2])
            {
                Task<string> task = translator.TransleteRussianToCodeAsync(txtSource.Text);
                task.ContinueWith(t => 
                this.Dispatcher.Invoke(() => { txtTarget.Text = t.Result; statusBlock.Text = string.Empty; })
                );
            }
            else if (lstDirectionOfTranslate.SelectedItem == lstDirectionOfTranslate.Items[3])
            {
                Task<string> task = translator.TransleteCodeToRussianAsync(txtSource.Text);
                task.ContinueWith(t =>
                this.Dispatcher.Invoke(() => { txtTarget.Text = t.Result; statusBlock.Text = string.Empty; })
                );
            }
            
        }

        private void CommandBinding_Executed_Open(object sender, ExecutedRoutedEventArgs e)
        {
            if (isTextChanged && txtSource.Text != string.Empty)
            {
                MessageBoxResult mbResult = MessageBox.Show("Do you want to save file?", "CodeMorseTranslator", MessageBoxButton.YesNoCancel);
                if (mbResult == MessageBoxResult.Yes)
                {
                    CommandBinding_Executed_Save(sender, null);
                }
                else if (mbResult == MessageBoxResult.Cancel)
                {
                    return;
                }
            }
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Text documents|*.txt";
            openDialog.ShowDialog();

            if (openDialog.FileName != string.Empty)
            {
                try
                {
                    Stream stream = new FileStream(openDialog.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(stream, Encoding.GetEncoding(1251));

                    txtSource.Text = reader.ReadToEnd();
                    reader.Close();
                    stream.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("File not found", "CodeMorseTranslator", MessageBoxButton.OK);
                }
                fileNameForSaving = openDialog.FileName;
                isTextChanged = false;
            }

        }

        private void CommandBinding_Executed_Close(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CommandBinding_Executed_New(object sender, ExecutedRoutedEventArgs e)
        {
            if (isTextChanged && txtSource.Text != string.Empty)
            {
                MessageBoxResult mbResult = MessageBox.Show("Do you want to save file?", "CodeMorseTranslator", MessageBoxButton.YesNoCancel);
                if (mbResult == MessageBoxResult.Yes)
                {
                    CommandBinding_Executed_Save(sender, null);
                }
                else if (mbResult == MessageBoxResult.No)
                {
                    txtSource.Text = string.Empty;
                    txtTarget.Text = string.Empty;
                    fileNameForSaving = string.Empty;
                }
            }
        }
     
        private void CommandBinding_Executed_Save(object sender, ExecutedRoutedEventArgs e)
        {
            if (fileNameForSaving != string.Empty)
            {
                try
                {
                    Stream stream = new FileStream(fileNameForSaving, FileMode.Open, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream, Encoding.GetEncoding(1251));

                    writer.Write(txtSource.Text);
                    writer.Close();
                    stream.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Can not save", "CodeMorseTranslator", MessageBoxButton.OK);
                }
                isTextChanged = false;
            }
            else
            {
                CommandBinding_Executed_Save_As(sender, e);
            }
        }

        private void CommandBinding_Executed_Save_As(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text documents|*.txt";
            saveDialog.ShowDialog();

            if (saveDialog.FileName != string.Empty)
            {
                try
                {
                    Stream stream = new FileStream(saveDialog.FileName, FileMode.Create, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(stream, Encoding.GetEncoding(1251));

                    writer.Write(txtSource.Text);
                    writer.Close();
                    stream.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Can not save", "CodeMorseTranslator", MessageBoxButton.OK);
                }
                fileNameForSaving = saveDialog.FileName;
                isTextChanged = false;
            }
        }

        private void txtSource_TextChanged(object sender, TextChangedEventArgs e)
        {
            isTextChanged = true;
        }

        private void CommandBinding_CanExecute_Save(object sender, CanExecuteRoutedEventArgs e)
        {
            if (txtSource.Text == string.Empty || !isTextChanged)
            {
                e.CanExecute = false;
            }
            else
            {
                e.CanExecute = true;
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (isTextChanged && txtSource.Text != string.Empty)
            {
                MessageBoxResult mbResult = MessageBox.Show("Do you want to save file?", "CodeMorseTranslator", MessageBoxButton.YesNoCancel);
                if (mbResult == MessageBoxResult.Yes)
                {
                    CommandBinding_Executed_Save(sender, null);
                }
                else if (mbResult == MessageBoxResult.Cancel)
                {
                   e.Cancel = true;
                    this.Height = 100;
                }
            }
        }
    }
}
