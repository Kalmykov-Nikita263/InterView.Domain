using InterView.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace InterView.Domain.ModelConfigurations;

public class InterviewConfiguration : IEntityTypeConfiguration<Interview>
{
    public void Configure(EntityTypeBuilder<Interview> builder)
    {
        builder.HasData(
            new Interview
            {
                InterviewId = new Guid("607ed998-da08-11ed-afa1-0242ac120002"),
                Title = "За кадром: жизнь и карьера режиссера",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddHours(1),
            }
        );
    }
}
