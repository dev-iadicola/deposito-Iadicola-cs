namespace FirstProject.App.Terminal.ObserverTest;

using FirstProject.App.Concreateds;
using FirstProject.App.IO;
using FirstProject.App.Pattern.Observer;
class ConcreatedTests
{
    public static void Example()
    {
        var subject = new ConcreateSubject();
        var obsA = new ConcreateObserver("Observer A");
        var obsB = new ConcreateObserver("Observer B");

        // observer Register
        subject.Attach(obsA);
        subject.Attach(obsB);

        // change state in sub 
        subject.State = 5;
        subject.State = 10;

        // remove obs 
        subject.Detach(obsA);

        // another change in subject
        subject.State = 15;

    }

    public static void MeteoTest()
    {
        var subject = new CentroMeteoSubject();
        var mobileObserver = new DisplayMobileObserve();
        var mobileObserver2 = new DisplayMobileObserve();
        var deskObs = new DeskObserve();
        subject.Attach(mobileObserver);
        subject.Attach(mobileObserver2);
        subject.Attach(deskObs);

        subject.Dati = IOutput.Make<string>("Inserisci nuovo dato meteo");

    }
    
    public static void GestioneCreazioneUtenteTest()
    {
        // Istnazio l'oggetto per creare il gestionale subject
        GestioneCreazioneUtenteSubject gcu = new GestioneCreazioneUtenteSubject();
        // istanzio i due observer
        ModuloLogObserve moduloLogObserve =  ModuloLogObserve.Instance;
        ModuloMarketingObserve moduloMarketingObserve =  ModuloMarketingObserve.Instance;

        gcu.Attach(moduloLogObserve);
        gcu.Attach(moduloMarketingObserve);

        gcu.CreateUser(IOutput.Make<string>("Inserisci il nome dell'utente che deve ricevere i moduli Log e Marketing"));

        

    }
}