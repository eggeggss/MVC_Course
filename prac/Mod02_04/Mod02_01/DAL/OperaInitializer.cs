using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod02_01.DAL
{
    public class OperaInitializer:DropCreateDatabaseAlways<OperaContext>
    {
        protected override void Seed(OperaContext context)
        {
            context.Operas.Add(new Models.Opera
            {
                Title="Cosi Fan Tutte",
                Year=1790,
                Composer="Mozart"
            });

            context.Operas.Add(new Models.Opera
            {
                Title = "Cosi Fan Tutte1",
                Year = 1790,
                Composer = "Mozart"
            });

            context.Operas.Add(new Models.Opera
            {
                Title = "Cosi Fan Tutte2",
                Year = 1790,
                Composer = "Mozart"
            });

            context.Operas.Add(new Models.Opera
            {
                Title = "Cosi Fan Tutte3",
                Year = 1790,
                Composer = "Mozart"
            });

            context.Operas.Add(new Models.Opera
            {
                Title = "Cosi Fan Tutte4",
                Year = 1790,
                Composer = "Mozart"
            });

            context.Operas.Add(new Models.Opera
            {
                Title = "Cosi Fan Tutte5",
                Year = 1790,
                Composer = "Mozart"
            });
            context.Operas.Add(new Models.Opera
            {
                Title = "Cosi Fan Tutte6",
                Year = 1790,
                Composer = "Mozart"
            });

            context.Operas.Add(new Models.Opera
            {
                Title = "Cosi Fan Tutte7",
                Year = 1790,
                Composer = "Mozart"
            });
            context.Operas.Add(new Models.Opera
            {
                Title = "Cosi Fan Tutte8",
                Year = 1790,
                Composer = "Mozart"
            });
            context.Operas.Add(new Models.Opera
            {
                Title = "Cosi Fan Tutte9",
                Year = 1790,
                Composer = "Mozart"
            });

            context.SaveChanges();

        }
    }
}
