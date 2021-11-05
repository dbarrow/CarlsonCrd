using Autodesk.AutoCAD.ApplicationServices;

namespace Carlson
{
    public class CarlsonCrd
    {
        internal Document acDoc = Application.DocumentManager.MdiActiveDocument;

        public void CrdOpen(string filename = "", int bOverwrite = 0, int crdType = 0)
        {
            if(filename != "")
            {
                string args = "(CrdOpen \"" + filename + "\" " + bOverwrite + " " + crdType + ") ";
                acDoc.SendStringToExecute(args, true, false, true);
            }            
        }

        public void CrdClose()
        {
            string args = "(CrdClose) ";
            acDoc.SendStringToExecute(args, true, false, true);
        }

        public void CrdAddPoint(double northing, double easting, double elevation, string point_id, string description)
        {
            string args = "(setq point (CrdPointInit " + northing + " " + easting + " " + elevation + " " + "\"" + point_id + "\" \"" + description + "\")) ";
            acDoc.SendStringToExecute(args, true, false, true);
            args = "(CrdAddPoint point) ";
            acDoc.SendStringToExecute(args, true, false, true);
        }

        public void CrdDraw(CrdDrawOptions cdo = null)
        {
            string options = null;
            if(cdo != null)
            {
                foreach (OptionPair op in cdo.OptionPairs)
                {
                    if (op.Value != "")
                    {
                        options += op.PairToString();
                    }
                }
            }

            string args = "(CrdDraw '(\"Points\" \"ALL\" ";
            if(options != null)
            {
                args += options;
            }

            args += ")) ";
            acDoc.SendStringToExecute(args, true, false, true);
        }
    }
}
