using SQLStoresAndQuerysCreator.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLStoresAndQuerysCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbProcedureType.Items.Add(Procedures.Todas);
            cmbProcedureType.Items.Add(Procedures.Insert);
            cmbProcedureType.Items.Add(Procedures.Seek);
            cmbProcedureType.Items.Add(Procedures.Update);

            cmbProcedureType.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            var sqlTable = txtTable.Text;

            // Decodifico la tabla
            var tabla = ObtenerCampos(sqlTable);

            lstCampo.DataSource = tabla;

            txtResult.Text = ProcedureContainer(txtDbName.Text, txtAutor.Text, txtTableName.Text, tabla, (Procedures)cmbProcedureType.SelectedItem);
        }

        /// <summary>
        /// Dado el texto decodifica lo ingresado lo devuelve en tipo lista
        /// </summary>
        /// <param name="sqlTable"></param>
        /// <returns></returns>
        private List<SqlEntidad> ObtenerCampos(string sqlTable)
        {
            var result = new List<SqlEntidad>();

            var vector = sqlTable.Split("\n");

            foreach (var item in vector)
            {
                if (string.IsNullOrWhiteSpace(item.Trim()))
                    continue;

                var vector2 = item.Split("\t");

                var campo = new SqlEntidad()
                {
                    Campo = vector2[0].Trim(),
                    TipoDato = vector2[1].Trim()
                };

                result.Add(campo);
            }

            return result;
        }


        private string ProcedureContainer(string databaseName, string autor, string nombreTabla, List<SqlEntidad> tabla, Procedures procedures)
        {
            var builder = new StringBuilder();

            builder.AppendLine($"USE {databaseName} GO");
            builder.AppendLine($"SET ANSI_NULLS ON");
            builder.AppendLine($"GO");
            builder.AppendLine($"SET QUOTED_IDENTIFIER ON");
            builder.AppendLine($"GO");
            
            builder.AppendLine($"-- ================================================================");
            builder.AppendLine($"-- Author: {autor}");
            builder.AppendLine($"-- Create date: {DateTime.Now.Date}");
            builder.AppendLine($"-- Description: Inserts a new item in the table");
            builder.AppendLine($"-- ================================================================");

            builder.AppendLine($"CREATE PROCEDURE [dbo].[{nombreTabla}_ADD]");

            bool primerIngreso = true;

            foreach (var item in tabla)
            {
                if (primerIngreso)
                    builder.AppendLine($"@{item.Campo} \t {item.TipoDato}");
                else
                    builder.AppendLine($",@{item.Campo} \t {item.TipoDato}");

                primerIngreso = false;
            }

            builder.AppendLine($"AS");
            builder.AppendLine($"BEGIN");
            builder.AppendLine($"SET NOCOUNT ON;");

            switch (procedures)
            {
                case Procedures.Todas:
                    builder.Append(InsertGenerico(nombreTabla, tabla));
                    builder.Append(UpdateGenerico(nombreTabla, tabla));
                    break;
                case Procedures.Insert:
                    break;
                case Procedures.Seek:
                    break;
                case Procedures.Update:
                    break;
                default:
                    break;
            }

            
            builder.AppendLine($"SELECT SCOPE_IDENTITY();");
            builder.AppendLine($"END");

            return builder.ToString();
        }

        /// <summary>
        /// Insert Generico para store procedure
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <param name="tabla"></param>
        /// <returns></returns>
        private string InsertGenerico(string nombreTabla, List<SqlEntidad> tabla)
        {
            var builder = new StringBuilder();
            bool primerIngreso = true;

            builder.AppendLine($"-- INSERT PARA LA TABLA {nombreTabla}");

            // Seccion campos
            builder.AppendLine($"INSERT INTO dbo.{nombreTabla}");
            builder.Append($"(");
            foreach (var item in tabla)
            {
                if (primerIngreso)
                    builder.AppendLine($"{item.Campo}");
                else
                    builder.AppendLine($",{item.Campo}");

                primerIngreso = false;
            }
            builder.AppendLine($")");

            primerIngreso = true;

            // Seccion Valores
            builder.AppendLine($"VALUES(");
            foreach (var item in tabla)
            {
                if (primerIngreso)
                    builder.AppendLine($"@{item.Campo}");
                else
                    builder.AppendLine($",@{item.Campo}");

                primerIngreso = false;
            }
            builder.AppendLine($")");

            builder.AppendLine($"-- FIN INSERT PARA LA TABLA {nombreTabla}");

            return builder.ToString();
        }

        /// <summary>
        /// Update generico para store procedure
        /// </summary>
        /// <param name="nombreTabla"></param>
        /// <param name="tabla"></param>
        /// <returns></returns>
        private string UpdateGenerico(string nombreTabla, List<SqlEntidad> tabla)
        {
            var builder = new StringBuilder();
            bool primerIngreso = true;

            builder.AppendLine($"-- UPDATE PARA LA TABLA {nombreTabla}");

            builder.AppendLine($"UPDATE dbo.{nombreTabla}");
            builder.AppendLine($"SET");

            foreach (var item in tabla)
            {
                if (primerIngreso)
                    builder.AppendLine($"{item.Campo} = @{item.Campo}");
                else
                    builder.AppendLine($",{item.Campo} = @{item.Campo}");

                primerIngreso = false;
            }

            builder.AppendLine($"-- WHERE {tabla[0].Campo} = @{tabla[0].Campo}");

            builder.AppendLine($"-- FIN UPDATE PARA LA TABLA {nombreTabla}");

            return builder.ToString();
        }
    }
}
