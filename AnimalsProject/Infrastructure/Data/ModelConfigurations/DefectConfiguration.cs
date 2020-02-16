﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.ModelConfigurations
{
    public class DefectConfiguration : IEntityTypeConfiguration<Defect>
    {
        public void Configure(EntityTypeBuilder<Defect> builder)
        {
            DataSeedConfigure(builder);
        }

        private void DataSeedConfigure(EntityTypeBuilder<Defect> builder)
        {
            builder.HasData(
                    new Defect
                    {
                        Id = 1,
                        Type = "Front pow disability"
                    },
                    new Defect
                    {
                        Id = 2,
                        Type = "Back pow disability"
                    },
                    new Defect
                    {
                        Id = 3,
                        Type = "Vision disability"
                    },
                    new Defect
                    {
                        Id = 4,
                        Type = "Hearing disability"
                    }
                );
        }
    }
}
