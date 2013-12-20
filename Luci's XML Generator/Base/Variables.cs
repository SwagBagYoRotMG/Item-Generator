namespace ItemMakerBeta.Base
{
    public class Variables
    {
        /* Public Strings */
            public string Title = "Item Maker";
            public string Version = "0.1";
            public string Copyright = "Copyright &copy; Mephistopheles Demon Server";
            public string Beta;
            public bool BetaBool = true;
            
            public void CheckBeta()
            {
                Beta = BetaBool ? "Beta" : "";
            }
    }
}
