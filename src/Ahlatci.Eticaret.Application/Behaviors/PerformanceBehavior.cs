using ArxOne.MrAdvice.Advice;
using Serilog;
using System.Diagnostics;

namespace Ahlatci.Eticaret.Application.Behaviors
{
    public class PerformanceBehavior : Attribute, IMethodAdvice
    {
        public void Advise(MethodAdviceContext context)
        {
            Stopwatch watch = new Stopwatch();

            //Kronometreyi başlat.
            watch.Start();

            context.Proceed();

            //Kronometreyi durdur.
            watch.Stop();

            //Kaç saniye sürdü.
            var totalDuration = watch.Elapsed.TotalSeconds;

            //Loglama.
            Log.Information($"{context.TargetName} metodu {totalDuration} saniyede tamamlandı.");
        }
    }
}
