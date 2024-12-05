﻿// <auto-generated />
using System;
using Lemoncode.Soccer.Infra.Repository.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lemoncode.Soccer.Infra.Repository.EfCore.Migrations
{
    [DbContext(typeof(SoccerContext))]
    partial class SoccerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lemoncode.Soccer.Infra.Repository.EfCore.Entities.GameEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("GameGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduledOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("HomeTeamId");

                    b.ToTable("Games", (string)null);
                });

            modelBuilder.Entity("Lemoncode.Soccer.Infra.Repository.EfCore.Entities.GoalEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("ScoredBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ScoredOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("TeamId");

                    b.ToTable("Goals", (string)null);
                });

            modelBuilder.Entity("Lemoncode.Soccer.Infra.Repository.EfCore.Entities.TeamEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams", (string)null);
                });

            modelBuilder.Entity("Lemoncode.Soccer.Infra.Repository.EfCore.Entities.GameEntity", b =>
                {
                    b.HasOne("Lemoncode.Soccer.Infra.Repository.EfCore.Entities.TeamEntity", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Lemoncode.Soccer.Infra.Repository.EfCore.Entities.TeamEntity", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AwayTeam");

                    b.Navigation("HomeTeam");
                });

            modelBuilder.Entity("Lemoncode.Soccer.Infra.Repository.EfCore.Entities.GoalEntity", b =>
                {
                    b.HasOne("Lemoncode.Soccer.Infra.Repository.EfCore.Entities.GameEntity", "Game")
                        .WithMany("Goals")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lemoncode.Soccer.Infra.Repository.EfCore.Entities.TeamEntity", "Team")
                        .WithMany("Goals")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Lemoncode.Soccer.Infra.Repository.EfCore.Entities.GameEntity", b =>
                {
                    b.Navigation("Goals");
                });

            modelBuilder.Entity("Lemoncode.Soccer.Infra.Repository.EfCore.Entities.TeamEntity", b =>
                {
                    b.Navigation("Goals");
                });
#pragma warning restore 612, 618
        }
    }
}
