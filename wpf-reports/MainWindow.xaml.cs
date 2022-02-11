using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

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
            ReportViewer.Reset();
            ReportViewer.LocalReport.DataSources.Clear();
            var dadosRelatorio = new List<DadosRelatorioFuncionario>();
            dadosRelatorio.Add(new DadosRelatorioFuncionario() { Nome = "André", Sobrenome = "Alves de Lima", Cargo = "Programador" });
            dadosRelatorio.Add(new DadosRelatorioFuncionario() { Nome = "Fulano", Sobrenome = "da Silva", Cargo = "Gerente" });
            dadosRelatorio.Add(new DadosRelatorioFuncionario() { Nome = "José", Sobrenome = "da Esquina", Cargo = "Analista" });
            dadosRelatorio.Add(new DadosRelatorioFuncionario() { Nome = "Maria", Sobrenome = "Souza", Cargo = "Analista" });
            var generalInfo = new GeneralInfo
                {Agencia = "123971", Projeto= "Projeto SAP"};
            var bindingSource = new BindingSource();
            var generalInfoList = new List<GeneralInfo>();
            generalInfoList.Add(generalInfo);
            var dataSource = new ReportDataSource("DataSetReport", dadosRelatorio);
            var dataSourceGeneralInfo = new ReportDataSource("DataSetGeneralInfo", generalInfoList);
            ReportViewer.LocalReport.DataSources.Add(dataSource);
            ReportViewer.LocalReport.DataSources.Add(dataSourceGeneralInfo);
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

public class GeneralInfo
{
    public string Agencia { get; set; }
    public string Projeto { get; set; }
    public string Gestor { get; set; }
    public string EmpreFiscalizada { get; set; }

}