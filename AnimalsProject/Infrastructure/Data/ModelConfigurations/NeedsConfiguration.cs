﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.ModelConfigurations
{
    public class NeedsConfiguration : IEntityTypeConfiguration<Needs>
    {
        public void Configure(EntityTypeBuilder<Needs> builder)
        {
            DataSeedConfigure(builder);
        }

        private void DataSeedConfigure(EntityTypeBuilder<Needs> builder)
        {
            builder.HasData(
                    new Needs
                    {
                        Id = 1,
                        Name = "Need to be housed with other animals"
                    },
                    new Needs
                    {
                        Id = 2,
                        Name = "Need to be housed apart from other animals"
                    },
                    new Needs
                    {
                        Id = 3,
                        Name = "Need for a suitable diet"
                    }
                );
        }
    }
}
