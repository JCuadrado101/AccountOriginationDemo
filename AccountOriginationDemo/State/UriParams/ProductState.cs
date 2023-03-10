using Fluxor;

namespace Account_Origination_Demo.State
{
    [FeatureState]
    public class ProductState
    {
       public string? ProductParam { get; }
        private ProductState() { }
        public ProductState(string productParam)
        {
            ProductParam = productParam;
        }
    }
}
