using Jardines2023.Entidades.Dtos;
using Jardines2023.Servicios.Interfaces;
using Jardines2023.Servicios.Servicios;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Jardines2023.Windows
{
    public partial class frmVentas : Form
    {
        private IServicioVentas servicio;
        private List<VentaDto> Listaventa;
        public frmVentas()
        {
            InitializeComponent();
            servicio = new ServicioVentas();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            Listaventa = servicio.GetVentas();
            MostrarDatos();
        }
      
        private void MostrarDatos()
        {
            dgvDatos.Rows.Clear();
            foreach (var venta in Listaventa)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r,venta);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }

        private void SetearFila(DataGridViewRow r, VentaDto venta)
        {
            r.Cells[0].Value = venta.VentaId;
            r.Cells[1].Value = venta.Fecha.ToShortDateString();
            r.Cells[2].Value = venta.cliente;
            r.Cells[3].Value = venta.total;
            r.Tag = venta;
        }

        private DataGridViewRow ConstruirFila()
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;   
        }
     
    }
}
