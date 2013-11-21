namespace Nancy.Embedded
{
    using Nancy;
    using Nancy.Bootstrapper;
    using Nancy.ViewEngines;

    /// <summary>
    /// Application registrations supporting views embedded in an assembly
    /// </summary>
    public class Registrations : ApplicationRegistrations
    {
        public Registrations()
        {
            this.Register<IViewLocationProvider>(typeof(EmbeddedResourceViewLocationProvider));
        }
    }
}
