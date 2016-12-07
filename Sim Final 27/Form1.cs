using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sim_Final_27.Entidades;
using Sim_Final_27.Generadores;
using System.Windows.Forms;

namespace Sim_Final_27
{
    public partial class Form1 : Form
    {
        private List<Reloj> listaRelojes;
        Operario op1;
        Operario op2;
        Operario op3;
        private double tiempo;
        private string evento;
        private int cola;
        private double rndLlegadaReloj;
        private double demoraProxLlegada;
        private double proxLlegada;
        private double rndControl1;
        private double rndControl2;
        private double tiempoControl;
        private double tiempoColaTotal = 0;
        private double tiempoTotalControl = 0;
        private int cantidadRelojesControlados = 0;
        private int idReloj = 1;
        private DataTable tablaSim;
        private DataTable tablaObjTemp;

        //Parametros modificables
        private double mediaExponencial;
        private double mediaNormal;
        private double desvEstNormal;


        public Form1()
        {
            InitializeComponent();
            listaRelojes = new List<Reloj>();
            op1 = new Operario(1);
            op2 = new Operario(2);
            op3 = new Operario(3);
            tiempo = 0;
            evento = "Inicio";
            inicializarTabla();
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            mediaExponencial = Double.Parse(txtMediaLlegada.Text);
            mediaNormal = double.Parse(txtMediaNormal.Text);
            desvEstNormal = double.Parse(txtDesvEstNormal.Text);

            //Paso 0
            rndLlegadaReloj = randomGenerator.generarRandom();
            demoraProxLlegada = randomGenerator.generarTiempoExponencial(rndLlegadaReloj, mediaExponencial);
            proxLlegada = tiempo + demoraProxLlegada;
            cola = 0;
            op1.estado = "Libre";
            op2.estado = "Libre";
            op3.estado = "Libre"; //Fin paso inicial
            imprimirFila(); //Imprimo Paso Final
            string[] prox;

            //Empieza el for para el resto de los pasos
            while (tiempo < Double.Parse(txtTiempo.Text))
            {
                prox = buscarProximoEvento(); //Devuelve vector de string, en 0 esta el nombre del evento, en 1 el tiempo
                evento = prox[0];
                tiempo = Double.Parse(prox[1]);

                switch (evento)
                {
                    case "Llegada reloj":
                        pasoLlegadaReloj();
                        break;
                    case "Fin Atencion Op 1":
                        finAtencion(op1);
                        break;
                    case "Fin Atencion Op 2":
                        finAtencion(op2);
                        break;
                    case "Fin Atencion Op 3":
                        finAtencion(op3);
                        break;

                }

                imprimirFila(); //Imprime la fila en ambas tablas con la informacion correspondiente

            }
            armarCargarTablaObjTemporales();
            calcularTiempoMedioCola();
            calcularTiempoMedioControl();
            calcularPorcentajeUsoOperarios();
            pintarFilas();


        }

        private void pintarFilas()
        {
            
            foreach (DataGridViewRow dgvr in dgvTablaSimulacion.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {
                    if (dgvr.Cells[0].Value.ToString() == "Inicio")
                    {
                        dgvr.DefaultCellStyle.BackColor = Color.LightYellow;
                    }
                    if (dgvr.Cells[0].Value.ToString() == "Llegada reloj")
                    {
                        dgvr.DefaultCellStyle.BackColor = Color.LightBlue;

                    }
                    if (dgvr.Cells[0].Value.ToString() == "Fin Atencion Op 1")
                    {
                        dgvr.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    if (dgvr.Cells[0].Value.ToString() == "Fin Atencion Op 2")
                    {
                        dgvr.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    if (dgvr.Cells[0].Value.ToString() == "Fin Atencion Op 3")
                    {
                        dgvr.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
        }

        private void calcularPorcentajeUsoOperarios()
        {
            double porcentajeUsoOperario = Math.Round(op1.tiempoOcupado * 100 / tiempo, 4);
            txtPorcentajeUsoOp1.Text = porcentajeUsoOperario + "%";
            porcentajeUsoOperario = Math.Round(op2.tiempoOcupado * 100 / tiempo, 4);
            txtPorcentajeUsoOp2.Text = porcentajeUsoOperario + "%";
            porcentajeUsoOperario = Math.Round(op3.tiempoOcupado * 100 / tiempo, 4);
            txtPorcentajeUsoOp3.Text = porcentajeUsoOperario + "%";
        }

        private void calcularTiempoMedioControl()
        {
            double acumuladorTiempoControl = 0;
            double tiempoControlRelojActual = 0;
            Reloj rel;
            for (int i = 0; i < listaRelojes.Count; i++)
            {
                rel = listaRelojes.ElementAt<Reloj>(i);
                tiempoControlRelojActual = rel.tiempoFinControl - rel.tiempoComienzoControl;
                acumuladorTiempoControl += tiempoControlRelojActual;
            }

            double tiempoMedioControl = Math.Round(acumuladorTiempoControl / cantidadRelojesControlados, 4);
            txtTiempoMedioControl.Text = tiempoMedioControl + " horas";

        }

        private void calcularTiempoMedioCola()
        {
            double acumuladorTiempoCola = 0;
            double tiempoColaRelojActual = 0;
            Reloj rel;
            for (int i = 0; i < listaRelojes.Count; i++)
            {
                rel = listaRelojes.ElementAt<Reloj>(i);
                if (rel.estado == "Ok")
                {
                    tiempoColaRelojActual = rel.tiempoComienzoControl - rel.tiempoEntrada;
                    acumuladorTiempoCola += tiempoColaRelojActual;
                }
            }

            double tiempoMedioCola = Math.Round(acumuladorTiempoCola / cantidadRelojesControlados, 4);

            txtTiempoMedioCola.Text = tiempoMedioCola + " horas";

        }

        private void finAtencion(Operario o)
        {
            //Termina de controlar, cargo acumuladores
            cantidadRelojesControlados++;
            tiempoTotalControl += o.relojAtendiendo.tiempoFinControl - o.relojAtendiendo.tiempoComienzoControl;
            o.tiempoOcupado += o.relojAtendiendo.tiempoFinControl - o.relojAtendiendo.tiempoComienzoControl;
            o.relojAtendiendo.estado = "Ok";

            //Si hay cola tomo el siguiente reloj, sino paso estado a Libre

            if (cola != 0)
            {
                Reloj proxReloj = null;
                for (int i = 0; i < listaRelojes.Count; i++)
                {
                    if (listaRelojes.ElementAt<Reloj>(i).estado == "En cola")
                    {
                        proxReloj = listaRelojes.ElementAt<Reloj>(i);
                        break;
                    }
                }
                inicioControl(proxReloj, o);
                cola--;

                //Aumento acumulador de tiempo de cola
                tiempoColaTotal += proxReloj.tiempoComienzoControl - proxReloj.tiempoEntrada;
            }
            else
            {
                o.estado = "Libre";
            }

        }

        private void imprimirFila()
        {
            //Primero imprimimos la tabla de objetos permanentes 

            DataRow fila = tablaSim.NewRow();
            fila["Evento"] = evento;
            fila["Tiempo"] = tiempo;
            fila["Rnd Prox Llegada"] = rndLlegadaReloj;
            fila["Tiempo Rnd Llegada"] = demoraProxLlegada;
            fila["Prox Llegada"] = proxLlegada;
            fila["Cola"] = cola;
            fila["Rnd Control 1"] = rndControl1;
            fila["Rnd Control 2"] = rndControl2;
            fila["Tiempo Control"] = tiempoControl;

            fila["Op 1 Estado"] = op1.estado;
            fila["Op 1 Termina Control"] = op1.tiempoFinAtencion;
            fila["Op 1 Tiempo Ocupado Acum"] = op1.tiempoOcupado;

            fila["Op 2 Estado"] = op2.estado;
            fila["Op 2 Termina Control"] = op2.tiempoFinAtencion;
            fila["Op 2 Tiempo Ocupado Acum"] = op2.tiempoOcupado;

            fila["Op 3 Estado"] = op3.estado;
            fila["Op 3 Termina Control"] = op3.tiempoFinAtencion;
            fila["Op 3 Tiempo Ocupado Acum"] = op3.tiempoOcupado;

            fila["Tiempo Cola Acum"] = tiempoColaTotal;
            fila["Tiempo Control Acum"] = tiempoTotalControl;
            fila["Cantidad Reloj Controlados"] = cantidadRelojesControlados;

            

            tablaSim.Rows.Add(fila);

            dgvTablaSimulacion.DataSource = tablaSim;
            


        }

        private void armarCargarTablaObjTemporales()
        {
            //Armo las filas segun la cantidad de relojes que haya en la lista

            Reloj rel;
            for (int i = 0; i < listaRelojes.Count; i++)
            {
                DataRow row = tablaObjTemp.NewRow();
                rel = listaRelojes.ElementAt<Reloj>(i);
                row["Id Reloj"] = rel.id;
                row["Tiempo Entrada"] = rel.tiempoEntrada;
                row["Tiempo Inicio Control"] = rel.tiempoComienzoControl;
                row["Tiempo Fin Control"] = rel.tiempoFinControl;
                tablaObjTemp.Rows.Add(row);
            }
            dgvTablaObjTemporales.DataSource = tablaObjTemp;
        }

        private void pasoLlegadaReloj()
        {
            //Llega un reloj, lo creo y agrego a la lista
            Reloj relojNuevo = new Reloj(idReloj, tiempo);
            idReloj++;

            listaRelojes.Add(relojNuevo);


            //Cuando llegara el proximo?
            rndLlegadaReloj = randomGenerator.generarRandom();
            demoraProxLlegada = randomGenerator.generarTiempoExponencial(rndLlegadaReloj, mediaExponencial);
            proxLlegada = tiempo + demoraProxLlegada;

            //Hay algun operario libre? Sino aumentamos la cola
            bool libre = false;
            if ((op1.estado == "Libre") || (op2.estado == "Libre") || (op3.estado == "Libre"))
            {
                libre = true;
            }

            if (libre == true)
            {
                if (op1.estado == "Libre")
                {
                    inicioControl(relojNuevo, op1);

                }
                else
                {
                    if (op2.estado == "Libre")
                    {
                        inicioControl(relojNuevo, op2);
                    }
                    else
                    {
                        if (op3.estado == "Libre")
                        {
                            inicioControl(relojNuevo, op3);
                        }

                    }
                }

            }
            else
            {
                cola = cola + 1;
            }




        }

        private void inicioControl(Reloj reloj, Operario o)
        {
            o.estado = "Ocupado";
            o.relojAtendiendo = reloj;
            reloj.estado = "Controlando";


            //Calculo cuando va a terminar el control
            rndControl1 = randomGenerator.generarRandom();
            rndControl2 = randomGenerator.generarRandom();

            tiempoControl = randomGenerator.generarTiempoDistNormal(rndControl1, rndControl2, mediaNormal, desvEstNormal);

            o.tiempoFinAtencion = tiempo + tiempoControl;


            //Tomo nota de cuando se empezo a controlar este reloj y cuando termina
            reloj.tiempoComienzoControl = tiempo;
            reloj.tiempoFinControl = tiempo + tiempoControl;
        }

        private string[] buscarProximoEvento()
        {
            double proximo = 100000;
            string evento = "";
            string[] rta = new string[2];

            //Busco proximo evento entre fin de control de operarios
            if (op1.tiempoFinAtencion > tiempo && op1.tiempoFinAtencion < proximo && op1.estado == "Ocupado")
            {
                proximo = op1.tiempoFinAtencion;
                evento = "Fin Atencion Op 1";
            }
            if (op2.tiempoFinAtencion > tiempo && op2.tiempoFinAtencion < proximo && op2.estado == "Ocupado")
            {
                proximo = op2.tiempoFinAtencion;
                evento = "Fin Atencion Op 2";
            }
            if (op3.tiempoFinAtencion > tiempo && op3.tiempoFinAtencion < proximo && op3.estado == "Ocupado")
            {
                proximo = op3.tiempoFinAtencion;
                evento = "Fin Atencion Op 3";
            }

            //Comparo con llegada de prox reloj
            if (proxLlegada < proximo)
            {
                proximo = proxLlegada;
                evento = "Llegada reloj";
            }
            rta[0] = evento;
            rta[1] = proximo.ToString();

            return rta;
        }

        private void inicializarTabla()
        {
            /*   DataColumn evento = new DataColumn("Evento");
               DataColumn tiempo = new DataColumn("Tiempo");
               DataColumn rndProxLlegada = new DataColumn("Rnd Prox Llegada");
               DataColumn tiempoRndLlegada = new DataColumn("Tiempo Rnd Llegada");
               DataColumn proxLlegada = new DataColumn("Prox Llegada");
               DataColumn cola = new DataColumn("Cola");
               DataColumn rndNormal1 = new DataColumn("Rnd Control 1");
               DataColumn rndNormal2 = new DataColumn("Rnd Control 2");
               DataColumn tiempoControl = new DataColumn("Tiempo Control");
               DataColumn op1Estado = new DataColumn("Op 1 Estado");
               DataColumn op1TiempoFin = new DataColumn("Op 1 Termina control");
               DataColumn op1AcumOcupado = new DataColumn("Op 1 Tiempo Ocupado Acum");
               DataColumn op2Estado = new DataColumn("Op 2 Estado");
               DataColumn op2TiempoFin = new DataColumn("Op 2 Termina control");
               DataColumn op2AcumOcupado = new DataColumn("Op 2 Tiempo Ocupado Acum");
               DataColumn op3Estado = new DataColumn("Op 3 Estado");
               DataColumn op3TiempoFin = new DataColumn("Op 3 Termina control");
               DataColumn op3AcumOcupado = new DataColumn("Op 3 Tiempo Ocupado Acum");
               DataColumn colaAcum = new DataColumn("Cola Acum");
               DataColumn tiempoTotalcontrol = new DataColumn("Tiempo Control Acum");
               DataColumn cantidadRelojesAtendidos = new DataColumn("Cantidad relojes controlados");*/

            tablaSim = new DataTable();

            tablaSim.Columns.Add("Evento");
            tablaSim.Columns.Add("Tiempo");
            tablaSim.Columns.Add("Rnd Prox Llegada");
            tablaSim.Columns.Add("Tiempo Rnd Llegada");
            tablaSim.Columns.Add("Prox Llegada");
            tablaSim.Columns.Add("Cola");
            tablaSim.Columns.Add("Rnd Control 1");
            tablaSim.Columns.Add("Rnd Control 2");
            tablaSim.Columns.Add("Tiempo Control");
            tablaSim.Columns.Add("Op 1 Estado");
            tablaSim.Columns.Add("Op 1 Termina Control");
            tablaSim.Columns.Add("Op 1 Tiempo Ocupado Acum");
            tablaSim.Columns.Add("Op 2 Estado");
            tablaSim.Columns.Add("Op 2 Termina Control");
            tablaSim.Columns.Add("Op 2 Tiempo Ocupado Acum");
            tablaSim.Columns.Add("Op 3 Estado");
            tablaSim.Columns.Add("Op 3 Termina Control");
            tablaSim.Columns.Add("Op 3 Tiempo Ocupado Acum");
            tablaSim.Columns.Add("Tiempo Cola Acum");
            tablaSim.Columns.Add("Tiempo Control Acum");
            tablaSim.Columns.Add("Cantidad Reloj Controlados");

            tablaObjTemp = new DataTable();
            tablaObjTemp.Columns.Add("Id Reloj");
            tablaObjTemp.Columns.Add("Tiempo Entrada");
            tablaObjTemp.Columns.Add("Tiempo Inicio Control");
            tablaObjTemp.Columns.Add("Tiempo Fin Control");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listaRelojes = new List<Reloj>();
            op1 = new Operario(1);
            op2 = new Operario(2);
            op3 = new Operario(3);
            tiempo = 0;
            evento = "Inicio";
            inicializarTabla();
            idReloj = 0;
            cantidadRelojesControlados = 0;
        }
    }
}
