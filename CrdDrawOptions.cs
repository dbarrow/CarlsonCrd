using System.Collections.Generic;

namespace Carlson
{
    public class CrdDrawOptions
    {
        public List<OptionPair> OptionPairs = new List<OptionPair>();
        public OptionPair SymbolName = new OptionPair("SymbolName", "");
        public OptionPair SymbolXScale = new OptionPair("SymbolXScale", "");
        public OptionPair SymbolYScale = new OptionPair("SymbolYScale", "");
        public OptionPair SymbolRotation = new OptionPair("SymbolRotation", "");
        public OptionPair SymbolLayer = new OptionPair("SymbolLayer", "");
        public OptionPair BlockName = new OptionPair("BlockName", "");
        public OptionPair BlockXScale = new OptionPair("BlockXScale", "");
        public OptionPair BlockYScale = new OptionPair("BlockYScale", "");
        public OptionPair BlockRotation = new OptionPair("BlockRotation", "");
        public OptionPair BlockNameLayer = new OptionPair("BlockNameLayer", "");
        public OptionPair BlockElevationLayer = new OptionPair("BlockElevationLayer", "");
        public OptionPair BlockDesriptionLayer = new OptionPair("BlockDescriptionLayer", "");
        public OptionPair PointLayer = new OptionPair("PointLayer", "");
        
        public CrdDrawOptions()
        {
            OptionPairs.Add(SymbolName);
            OptionPairs.Add(SymbolXScale);
            OptionPairs.Add(SymbolYScale);
            OptionPairs.Add(SymbolRotation);
            OptionPairs.Add(SymbolLayer);
            OptionPairs.Add(BlockName);
            OptionPairs.Add(BlockXScale);
            OptionPairs.Add(BlockYScale);
            OptionPairs.Add(BlockRotation);
            OptionPairs.Add(BlockNameLayer);
            OptionPairs.Add(BlockElevationLayer);
            OptionPairs.Add(BlockDesriptionLayer);
            OptionPairs.Add(PointLayer);
        }
    }

    public class OptionPair
    {
        public string Key;
        public string Value { get; set; }
        public OptionPair() { }
        public OptionPair(string key, string val)
        {
            Key = key;
            Value = val;
        }

        public string PairToString()
        {
            return "\"" + Key + "\" \"" + Value + "\"";
        }
    }
}
