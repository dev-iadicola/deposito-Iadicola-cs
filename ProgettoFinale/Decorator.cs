namespace FirstProject.ProgettoFinale;

public abstract class ProductDecorator : IProduct
{
    protected IProduct _product;
    public ProductDecorator(IProduct product) => _product = product;

    public virtual string Name => _product.Name;
    public virtual decimal BasePrice => _product.BasePrice;
}

public class GiftWrapDecorator : ProductDecorator
{
    public GiftWrapDecorator(IProduct product) : base(product) { }
    public override string Name => _product.Name + " + Confezione Regalo";
    public override decimal BasePrice => _product.BasePrice + 3m;
}

public class EngravingDecorator : ProductDecorator
{
    public EngravingDecorator(IProduct product) : base(product) { }
    public override string Name => _product.Name + " + Incisione";
    public override decimal BasePrice => _product.BasePrice + 5m;
}
