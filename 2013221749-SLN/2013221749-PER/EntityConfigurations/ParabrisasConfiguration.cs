﻿using _2013221749_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013221749_PER.EntityConfigurations
{
    public class ParabrisasConfiguration : EntityTypeConfiguration<Parabrisas>
    {
        public ParabrisasConfiguration()
        {
            ToTable("Parabrisas")
               .HasKey(c => c.ParabrisasId);

            Property(v => v.NumSerie)
                 .IsRequired()
                 .HasMaxLength(100);

        }

    }
}
