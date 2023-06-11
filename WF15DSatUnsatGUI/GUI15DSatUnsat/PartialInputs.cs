using FlowComLib;
using FlowModelLib;
using Microsoft.VisualBasic.ApplicationServices;
using ScottPlot.Drawing.Colormaps;
using ScottPlot.MarkerShapes;
using ScottPlot.Palettes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI15DSATUNSAT
{
    public partial class MainForm 
    {
        /// <summary>
        /// Class to store all model variables
        /// </summary>
        public Model_ty_model Model;



        #region Parameters

        //private void radiobutton_Parameters_Typematrixstorage_Dense_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (this.Model.Com_Ty_Parameters.Typesolution != 1 && this.Model.Com_Ty_Parameters.Typesolution != 2)
        //        ChangeTypeSolution(1);
        //}

        //private void radiobutton_Parameters_Typematrixstorage_CSR_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (this.Model.Com_Ty_Parameters.Typesolution == 1 | this.Model.Com_Ty_Parameters.Typesolution == 2 | this.Model.Com_Ty_Parameters.Typesolution == 15 | this.Model.Com_Ty_Parameters.Typesolution == 16)
        //        ChangeTypeSolution(3);
        //}

        //private void radiobutton_Parameters_Typematrixstorage_Banded_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (this.Model.Com_Ty_Parameters.Typesolution != 15 && this.Model.Com_Ty_Parameters.Typesolution != 16)
        //        ChangeTypeSolution(15);
        //}
        private void SetTypeSolution_Typematrixstorage(object sender, EventArgs e)
        {

            //!(typesolution)Type of solution used in calcs:
            //!Number | sparsity | solver | preconditioner
            //!   1     dense gauss    none
            //!   2     dense gauss    jacobi

            //!   3     csr DSS      none
            //!   4     csr DSS      jacobi
            //!   5     csr DSS      ilu0
            //!   6     csr DSS      ilut
            //!   7     csr PARADISO none
            //!   8     csr PARADISO jacobi
            //!   9     csr PARADISO ilu0
            //!   10    csr PARADISO ilut
            //!   11    csr FGMRES   none
            //!   12    csr FGMRES   jacobi
            //!   13    csr FGMRES   ilu0
            //!   14    csr FGMRES   ilut
            //!   15    banded gauss    none
            //!   16    banded gauss    jacobi

            if (radiobutton_Parameters_Typematrixstorage_Dense.Checked)
            {
                if (radiobutton_Parameters_Preconditioner_ILU0.Checked | radiobutton_Parameters_Preconditioner_ILUT.Checked) radiobutton_Parameters_Preconditioner_None.Select();
                if (radiobutton_Parameters_Solver_IntelDSS.Checked | radiobutton_Parameters_Solver_Paradiso.Checked | radiobutton_Parameters_Solver_FMGRES.Checked) radiobutton_Parameters_Solver_Direct.Select();
            }
            else if (radiobutton_Parameters_Typematrixstorage_CSR.Checked)
            {
                if (radiobutton_Parameters_Solver_Direct.Checked) radiobutton_Parameters_Solver_IntelDSS.Select();
            }
            else
            {
                if (radiobutton_Parameters_Preconditioner_ILU0.Checked | radiobutton_Parameters_Preconditioner_ILUT.Checked) radiobutton_Parameters_Preconditioner_None.Select();
                if (radiobutton_Parameters_Solver_IntelDSS.Checked | radiobutton_Parameters_Solver_Paradiso.Checked | radiobutton_Parameters_Solver_FMGRES.Checked) radiobutton_Parameters_Solver_Direct.Select();
            }

            SetTypeSolution();
        }

        private void SetTypeSolution_Solver(object sender, EventArgs e)
        {

            //!(typesolution)Type of solution used in calcs:
            //!Number | sparsity | solver | preconditioner
            //!   1     dense gauss    none
            //!   2     dense gauss    jacobi

            //!   3     csr DSS      none
            //!   4     csr DSS      jacobi
            //!   5     csr DSS      ilu0
            //!   6     csr DSS      ilut
            //!   7     csr PARADISO none
            //!   8     csr PARADISO jacobi
            //!   9     csr PARADISO ilu0
            //!   10    csr PARADISO ilut
            //!   11    csr FGMRES   none
            //!   12    csr FGMRES   jacobi
            //!   13    csr FGMRES   ilu0
            //!   14    csr FGMRES   ilut
            //!   15    banded gauss    none
            //!   16    banded gauss    jacobi

            if (radiobutton_Parameters_Solver_Direct.Checked | radiobutton_Parameters_Typematrixstorage_Banded.Checked)
            {
                if (radiobutton_Parameters_Preconditioner_ILU0.Checked | radiobutton_Parameters_Preconditioner_ILUT.Checked) radiobutton_Parameters_Preconditioner_None.Select();
                if (radiobutton_Parameters_Typematrixstorage_CSR.Checked) radiobutton_Parameters_Typematrixstorage_Dense.Select();
            }
            else if (radiobutton_Parameters_Solver_IntelDSS.Checked | radiobutton_Parameters_Solver_Paradiso.Checked | radiobutton_Parameters_Solver_FMGRES.Checked)
            {
                radiobutton_Parameters_Typematrixstorage_CSR.Select();
            }

            SetTypeSolution();
        }

        private void SetTypeSolution_Preconditioner(object sender, EventArgs e)
        {

            //!(typesolution)Type of solution used in calcs:
            //!Number | sparsity | solver | preconditioner
            //!   1     dense gauss    none
            //!   2     dense gauss    jacobi

            //!   3     csr DSS      none
            //!   4     csr DSS      jacobi
            //!   5     csr DSS      ilu0
            //!   6     csr DSS      ilut
            //!   7     csr PARADISO none
            //!   8     csr PARADISO jacobi
            //!   9     csr PARADISO ilu0
            //!   10    csr PARADISO ilut
            //!   11    csr FGMRES   none
            //!   12    csr FGMRES   jacobi
            //!   13    csr FGMRES   ilu0
            //!   14    csr FGMRES   ilut
            //!   15    banded gauss    none
            //!   16    banded gauss    jacobi

            if (radiobutton_Parameters_Preconditioner_ILU0.Checked | radiobutton_Parameters_Preconditioner_ILUT.Checked)
            {
                if (radiobutton_Parameters_Solver_Direct.Checked) radiobutton_Parameters_Solver_IntelDSS.Select();
                radiobutton_Parameters_Typematrixstorage_CSR.Select();
            }

            SetTypeSolution();
        }

        private void SetTypeSolution()
        {

            //!(typesolution)Type of solution used in calcs:
            //!Number | sparsity | solver | preconditioner
            //!   1     dense gauss    none
            //!   2     dense gauss    jacobi

            //!   3     csr DSS      none
            //!   4     csr DSS      jacobi
            //!   5     csr DSS      ilu0
            //!   6     csr DSS      ilut
            //!   7     csr PARADISO none
            //!   8     csr PARADISO jacobi
            //!   9     csr PARADISO ilu0
            //!   10    csr PARADISO ilut
            //!   11    csr FGMRES   none
            //!   12    csr FGMRES   jacobi
            //!   13    csr FGMRES   ilu0
            //!   14    csr FGMRES   ilut
            //!   15    banded gauss    none
            //!   16    banded gauss    jacobi


            if (radiobutton_Parameters_Typematrixstorage_Dense.Checked && radiobutton_Parameters_Solver_Direct.Checked && radiobutton_Parameters_Preconditioner_None.Checked) ChangeTypeSolution(1);
            if (radiobutton_Parameters_Typematrixstorage_Dense.Checked && radiobutton_Parameters_Solver_Direct.Checked && radiobutton_Parameters_Preconditioner_Jacobi.Checked) ChangeTypeSolution(2);

            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_IntelDSS.Checked && radiobutton_Parameters_Preconditioner_None.Checked) ChangeTypeSolution(3);
            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_IntelDSS.Checked && radiobutton_Parameters_Preconditioner_Jacobi.Checked) ChangeTypeSolution(4);
            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_IntelDSS.Checked && radiobutton_Parameters_Preconditioner_ILU0.Checked) ChangeTypeSolution(5);
            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_IntelDSS.Checked && radiobutton_Parameters_Preconditioner_ILUT.Checked) ChangeTypeSolution(6);

            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_Paradiso.Checked && radiobutton_Parameters_Preconditioner_None.Checked) ChangeTypeSolution(7);
            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_Paradiso.Checked && radiobutton_Parameters_Preconditioner_Jacobi.Checked) ChangeTypeSolution(8);
            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_Paradiso.Checked && radiobutton_Parameters_Preconditioner_ILU0.Checked) ChangeTypeSolution(9);
            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_Paradiso.Checked && radiobutton_Parameters_Preconditioner_ILUT.Checked) ChangeTypeSolution(10);

            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_FMGRES.Checked && radiobutton_Parameters_Preconditioner_None.Checked) ChangeTypeSolution(11);
            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_FMGRES.Checked && radiobutton_Parameters_Preconditioner_Jacobi.Checked) ChangeTypeSolution(12);
            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_FMGRES.Checked && radiobutton_Parameters_Preconditioner_ILU0.Checked) ChangeTypeSolution(13);
            if (radiobutton_Parameters_Typematrixstorage_CSR.Checked && radiobutton_Parameters_Solver_FMGRES.Checked && radiobutton_Parameters_Preconditioner_ILUT.Checked) ChangeTypeSolution(14);

            if (radiobutton_Parameters_Typematrixstorage_Banded.Checked && radiobutton_Parameters_Solver_Direct.Checked && radiobutton_Parameters_Preconditioner_None.Checked) ChangeTypeSolution(15);
            if (radiobutton_Parameters_Typematrixstorage_Banded.Checked && radiobutton_Parameters_Solver_Direct.Checked && radiobutton_Parameters_Preconditioner_Jacobi.Checked) ChangeTypeSolution(16);
        }



        #endregion
        private void ChangeTypeSolution(int ntype)
        {
            //!(typesolution)Type of solution used in calcs:
            //!Number | sparsity | solver | preconditioner
            //!   1     dense gauss    none
            //!   2     dense gauss    jacobi
            //!   3     csr DSS      none
            //!   4     csr DSS      jacobi
            //!   5     csr DSS      ilu0
            //!   6     csr DSS      ilut
            //!   7     csr PARADISO none
            //!   8     csr PARADISO jacobi
            //!   9     csr PARADISO ilu0
            //!   10    csr PARADISO ilut
            //!   11    csr FGMRES   none
            //!   12    csr FGMRES   jacobi
            //!   13    csr FGMRES   ilu0
            //!   14    csr FGMRES   ilut
            //!   15    banded gauss    none
            //!   16    banded gauss    jacobi


            switch (ntype)
            {
                default:
                    radiobutton_Parameters_Typematrixstorage_Dense.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = true;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = false;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = false;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = false;
                    radiobutton_Parameters_Solver_Direct.Checked = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = false;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = false;
                    radiobutton_Parameters_Preconditioner_None.Checked = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 1;
                    break;
                case 2:
                    radiobutton_Parameters_Typematrixstorage_Dense.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = true;
                    radiobutton_Parameters_Solver_Direct.Checked = true;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = false;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = false;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = false;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Checked = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = false;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = false;

                    this.Model.Com_Ty_Parameters.Typesolution = 2;
                    break;
                case 3:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_IntelDSS.Checked = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_None.Checked = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 3;
                    break;
                case 4:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_IntelDSS.Checked = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Checked = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 4;
                    break;
                case 5:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_IntelDSS.Checked = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Checked = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 5;
                    break;
                case 6:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_IntelDSS.Checked = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Checked = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 6;
                    break;
                case 7:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Checked = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_None.Checked = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 7;
                    break;
                case 8:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Checked = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Checked = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 8;
                    break;
                case 9:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Checked = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Checked = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 9;
                    break;
                case 10:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Checked = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Checked = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 10;
                    break;
                case 11:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Checked = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_None.Checked = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 11;
                    break;
                case 12:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Checked = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Checked = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 12;
                    break;
                case 13:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Checked = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Checked = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 13;
                    break;
                case 14:
                    radiobutton_Parameters_Typematrixstorage_CSR.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = false;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = true;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = true;
                    radiobutton_Parameters_Solver_FMGRES.Checked = true;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILUT.Checked = true;

                    this.Model.Com_Ty_Parameters.Typesolution = 14;
                    break;
                case 15:
                    radiobutton_Parameters_Typematrixstorage_Banded.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = true;
                    radiobutton_Parameters_Solver_Direct.Checked = true;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = false;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = false;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = false;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_None.Checked = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = false;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = false;

                    this.Model.Com_Ty_Parameters.Typesolution = 15;
                    break;
                case 16:
                    radiobutton_Parameters_Typematrixstorage_Banded.Checked = true;

                    radiobutton_Parameters_Solver_Direct.Enabled = true;
                    radiobutton_Parameters_Solver_Direct.Checked = true;
                    radiobutton_Parameters_Solver_IntelDSS.Enabled = false;
                    radiobutton_Parameters_Solver_Paradiso.Enabled = false;
                    radiobutton_Parameters_Solver_FMGRES.Enabled = false;

                    radiobutton_Parameters_Preconditioner_None.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Enabled = true;
                    radiobutton_Parameters_Preconditioner_Jacobi.Checked = true;
                    radiobutton_Parameters_Preconditioner_ILU0.Enabled = false;
                    radiobutton_Parameters_Preconditioner_ILUT.Enabled = false;

                    this.Model.Com_Ty_Parameters.Typesolution = 16;
                    break;
            }
        }

        

        #region SetHelp
        private void Set_Help(string title, string help)
        {
            string htmltext = @"<html style=""color:DarkGreen;background-color:FloralWhite;""><header><h2><p >" + title + @"</p></h2></header>"
                              + help + @"</html>";
            webBrowser_Right.DocumentText = htmltext;
        }

        private void textbox_SetHelp(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            switch (textbox.Name)
            {
                case "textbox_Parameters_Epsh_tol": Set_Help("<p>Epsh_tol", "Tolerance for the pressure head [L] to finish iterations for the current time-step.</p><p><i>(Suggested value: 0.001)</i></p>"); break;
                default: Set_Help("", ""); break;
            }
        }
        #endregion

        #region Layers
        private void radioButton_Layers_Topboundbyh_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Layers_Topboundbyh.Checked)
            {
                this.Model.Com_Ty_Layers.Topboundbyh = true;
                dataGridView_Boundary.Columns["boundary_Hbound"].Visible = true;
                dataGridView_Boundary.Columns["boundary_Qbound"].Visible = false;
                //boundary_Hbound.Visible = true;
                //boundary_Qbound.Visible = false;
            }
            else
            {
                this.Model.Com_Ty_Layers.Topboundbyh = false;
                dataGridView_Boundary.Columns["boundary_Hbound"].Visible = false;
                dataGridView_Boundary.Columns["boundary_Qbound"].Visible = true;
                //boundary_Hbound.Visible = false;
                //boundary_Qbound.Visible = false;

            }
        }

        private void radioButton_Layers_Bottombyphl_Click(object sender, EventArgs e)
        {
            this.Model.Com_Ty_Layers.Bottombyphl = true;
        }

        private void radioButton_Layers_BottomImpermeable_Click(object sender, EventArgs e)
        {
            this.Model.Com_Ty_Layers.Bottombyphl = false;
        }

        private void dataGridView_Layers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //sourceIDMaterial = new BindingSource(com_Ty_Material.Select(x => x.Id).ToList(), null);
            //layers_Material.Items.Clear();
            //List<int> tempID = com_Ty_Material.Select(x => x.Id).ToList();
            //for (int i = 0;i< tempID.Count;i++)
            //    layers_Material.Items.Add(tempID[i]);
            ////layers_Material.DataSource = sourceIDMaterial;
            //if (sourceIDMaterial.Count == 0) dataGridView_Layers.CurrentCell.Value = 0;
            //else dataGridView_Layers.CurrentCell.Value = com_Ty_Layers.Layers[dataGridView_Layers.CurrentRow.Index].Material.Id;
            //layers_Material.DataSource = sourceIDMaterial;
            MessageBox.Show(e.Exception.ToString());
        }


        private void dataGridView_Layers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            if (!(dataGridView_Layers.CurrentCell is null))
            {
                foreach (DataGridViewRow row in dataGridView_Layers.Rows)
                {
                    row.Cells["layers_IDlayer"].Value = row.Index;
                }
                switch (dataGridView_Layers.CurrentCell.OwningColumn.HeaderText)
                {
                    default:
                        break;
                    case "IDMaterial":
                        Com_ty_layer layertemp = (Com_ty_layer)dataGridView_Layers.CurrentRow.DataBoundItem;
                        layertemp.IDMaterial = (int)dataGridView_Layers.CurrentCell.Value;
                        break;
                    case "IDMaterialHidden":
                        dataGridView_Layers.CurrentRow.Cells[0].Value = (int)dataGridView_Layers.CurrentCell.Value;
                        //dataGridView_Layers.CommitEdit(DataGridViewDataErrorContexts.Commit);
                        break;
                }
                if (dataGridView_Layers.CurrentCell.OwningColumn.HeaderText == "IDMaterial")
                {
                    Com_ty_layer layertemp = (Com_ty_layer)dataGridView_Layers.CurrentRow.DataBoundItem;
                    layertemp.IDMaterial = (int)dataGridView_Layers.CurrentCell.Value;
                }
            }
        }

        private void dataGridView_Layers_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (!(dataGridView_Layers.CurrentCell is null))
                if (dataGridView_Layers.CurrentCell.OwningColumn.HeaderText == "IDMaterial")
                {
                    // This fires the cell value changed handler below
                    dataGridView_Layers.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }

        }

        private void dataGridView_Layers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView_Layers.Rows)
            {
                if (!(Model.Materials.Materials.Count == 0))
                    row.Cells[0].Value = row.Cells["layers_IDMaterialHidden"].Value;
            }

        }
        #endregion

        #region Mesh
        private void dataGridView_VerticalModules_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dataGridView_VerticalModules.CurrentCell is null))
            {
                foreach (DataGridViewRow row in dataGridView_VerticalModules.Rows)
                {
                    row.Cells["verticalModules_ID"].Value = row.Index;
                }
            }
        }
        #endregion


    }
}
