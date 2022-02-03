using System;
using System.Collections.Generic;
using System.Windows;
namespace wpf_reports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }
        private void ReportViewer_Load(object sender, EventArgs e)
        {
            var dadosRelatorio = new List<DadosRelatorioFuncionario>();
            dadosRelatorio.Add(new DadosRelatorioFuncionario() { Nome = "André", Sobrenome = "Alves de Lima", Cargo = "Programador" });
            dadosRelatorio.Add(new DadosRelatorioFuncionario() { Nome = "Fulano", Sobrenome = "da Silva", Cargo = "Gerente" });
            dadosRelatorio.Add(new DadosRelatorioFuncionario() { Nome = "José", Sobrenome = "da Esquina", Cargo = "Analista" });
            dadosRelatorio.Add(new DadosRelatorioFuncionario() { Nome = "Maria", Sobrenome = "Souza", Cargo = "Analista" });
 
            var dataSource = new Microsoft.Reporting.WinForms.ReportDataSource("DataSetReport", dadosRelatorio);
            ReportViewer.LocalReport.DataSources.Add(dataSource);
            ReportViewer.LocalReport.ReportEmbeddedResource = "Report1.rdlc";
            ReportViewer.LocalReport.ReportPath = "Report1.rdlc";
            ReportViewer.RefreshReport();
            
        }
    }
}
public class DadosRelatorioFuncionario
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Cargo { get; set; }
}