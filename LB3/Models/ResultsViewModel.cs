using Google.OrTools.LinearSolver;

namespace LB3.Models
{
    public class ResultsViewModel
    {
        public DataViewModel dataViewModel;

        public ResultsViewModel(DataViewModel dataViewModel)
        {
            this.dataViewModel = dataViewModel;
            SolverXlam();
        }

        public void SolverXlam()
        {
            Solver solver = Solver.CreateSolver("GLOP");

            Variable x1 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x1");
            Variable x2 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x2");
            Variable x3 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x3");
            Variable x4 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x4");
            Variable x5 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x5");
            Variable x6 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x6");

            solver.Add(
                (x1 * dataViewModel.A1_ChZag1 + x2 * dataViewModel.A1_ChZag2 + x3 * dataViewModel.A1_ChZag3
                + x4 * dataViewModel.A1_ChZag4 + x5 * dataViewModel.A1_ChZag5 + x6 * dataViewModel.A1_ChZag6)
                == (dataViewModel.Isx_R * dataViewModel.A1_ChZagO)
                );

            solver.Add(
                (x1 * dataViewModel.A2_ChZag1 + x2 * dataViewModel.A2_ChZag2 + x3 * dataViewModel.A2_ChZag3
                + x4 * dataViewModel.A2_ChZag4 + x5 * dataViewModel.A2_ChZag5 + x6 * dataViewModel.A2_ChZag6)
                == (dataViewModel.Isx_R * dataViewModel.A2_ChZagO)
                );

            solver.Add(
                (x1 * dataViewModel.A3_ChZag1 + x2 * dataViewModel.A3_ChZag2 + x3 * dataViewModel.A3_ChZag3
                + x4 * dataViewModel.A3_ChZag4 + x5 * dataViewModel.A3_ChZag5 + x6 * dataViewModel.A3_ChZag6)
                == (dataViewModel.Isx_R * dataViewModel.A3_ChZagO)
                );

            solver.Add(
                (x1 * dataViewModel.A4_ChZag1 + x2 * dataViewModel.A4_ChZag2 + x3 * dataViewModel.A4_ChZag3
                + x4 * dataViewModel.A4_ChZag4 + x5 * dataViewModel.A4_ChZag5 + x6 * dataViewModel.A4_ChZag6)
                == (dataViewModel.Isx_R * dataViewModel.A4_ChZagO)
                );

            solver.Add(
                (x1 * dataViewModel.A5_ChZag1 + x2 * dataViewModel.A5_ChZag2 + x3 * dataViewModel.A5_ChZag3
                + x4 * dataViewModel.A5_ChZag4 + x5 * dataViewModel.A5_ChZag5 + x6 * dataViewModel.A5_ChZag6)
                == (dataViewModel.Isx_R * dataViewModel.A5_ChZagO)
                );

            solver.Add(
                (x1 * dataViewModel.A6_ChZag1 + x2 * dataViewModel.A6_ChZag2 + x3 * dataViewModel.A6_ChZag3
                + x4 * dataViewModel.A6_ChZag4 + x5 * dataViewModel.A6_ChZag5 + x6 * dataViewModel.A6_ChZag6)
                == (dataViewModel.Isx_R * dataViewModel.A6_ChZagO)
                );

            solver.Minimize(Otxod1 * x1 + Otxod2 * x2 + Otxod3 * x3 + Otxod4 * x4 + Otxod5 * x5 + Otxod6 * x6);

            Solver.ResultStatus resultStatus= solver.Solve();

            Cel = Math.Round(solver.Objective().Value(), 0);

            X1 = Math.Round(x1.SolutionValue(), 0);
            X2 = Math.Round(x2.SolutionValue(), 0);
            X3 = Math.Round(x3.SolutionValue(), 0);
            X4 = Math.Round(x4.SolutionValue(), 0);
            X5 = Math.Round(x5.SolutionValue(), 0);
            X6 = Math.Round(x6.SolutionValue(), 0);
        }

        public double Cel { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }
        public double X4 { get; set; }
        public double X5 { get; set; }
        public double X6 { get; set; }

        #region Отходы

        public double Otxod1
        {
            get => dataViewModel.Isx_F - (
                dataViewModel.A1_ChZag * dataViewModel.A1_ChZag1 +
                dataViewModel.A2_ChZag * dataViewModel.A2_ChZag1 +
                dataViewModel.A3_ChZag * dataViewModel.A3_ChZag1 +
                dataViewModel.A4_ChZag * dataViewModel.A4_ChZag1 +
                dataViewModel.A5_ChZag * dataViewModel.A5_ChZag1 +
                dataViewModel.A6_ChZag * dataViewModel.A6_ChZag1
                );
        }

        public double Otxod2
        {
            get => dataViewModel.Isx_F - (
                dataViewModel.A1_ChZag * dataViewModel.A1_ChZag2 +
                dataViewModel.A2_ChZag * dataViewModel.A2_ChZag2 +
                dataViewModel.A3_ChZag * dataViewModel.A3_ChZag2 +
                dataViewModel.A4_ChZag * dataViewModel.A4_ChZag2 +
                dataViewModel.A5_ChZag * dataViewModel.A5_ChZag2 +
                dataViewModel.A6_ChZag * dataViewModel.A6_ChZag2
                );
        }

        public double Otxod3
        {
            get => dataViewModel.Isx_F - (
                dataViewModel.A1_ChZag * dataViewModel.A1_ChZag3 +
                dataViewModel.A2_ChZag * dataViewModel.A2_ChZag3 +
                dataViewModel.A3_ChZag * dataViewModel.A3_ChZag3 +
                dataViewModel.A4_ChZag * dataViewModel.A4_ChZag3 +
                dataViewModel.A5_ChZag * dataViewModel.A5_ChZag3 +
                dataViewModel.A6_ChZag * dataViewModel.A6_ChZag3
                );
        }

        public double Otxod4
        {
            get => dataViewModel.Isx_F - (
                dataViewModel.A1_ChZag * dataViewModel.A1_ChZag4 +
                dataViewModel.A2_ChZag * dataViewModel.A2_ChZag4 +
                dataViewModel.A3_ChZag * dataViewModel.A3_ChZag4 +
                dataViewModel.A4_ChZag * dataViewModel.A4_ChZag4 +
                dataViewModel.A5_ChZag * dataViewModel.A5_ChZag4 +
                dataViewModel.A6_ChZag * dataViewModel.A6_ChZag4
                );
        }

        public double Otxod5
        {
            get => dataViewModel.Isx_F - (
                dataViewModel.A1_ChZag * dataViewModel.A1_ChZag5 +
                dataViewModel.A2_ChZag * dataViewModel.A2_ChZag5 +
                dataViewModel.A3_ChZag * dataViewModel.A3_ChZag5 +
                dataViewModel.A4_ChZag * dataViewModel.A4_ChZag5 +
                dataViewModel.A5_ChZag * dataViewModel.A5_ChZag5 +
                dataViewModel.A6_ChZag * dataViewModel.A6_ChZag5
                );
        }

        public double Otxod6
        {
            get => dataViewModel.Isx_F - (
                dataViewModel.A1_ChZag * dataViewModel.A1_ChZag6 +
                dataViewModel.A2_ChZag * dataViewModel.A2_ChZag6 +
                dataViewModel.A3_ChZag * dataViewModel.A3_ChZag6 +
                dataViewModel.A4_ChZag * dataViewModel.A4_ChZag6 +
                dataViewModel.A5_ChZag * dataViewModel.A5_ChZag6 +
                dataViewModel.A6_ChZag * dataViewModel.A6_ChZag6
                );
        }
        #endregion

    }
}
