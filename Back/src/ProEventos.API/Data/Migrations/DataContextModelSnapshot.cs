﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProEventos.API.Data;

namespace ProEventos.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ProEventos.API.Models.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");
                    b.Property<string>("DataEvento")
                        .HasColumnType("TEXT");
                    b.Property<string>("ImagemURL")
                        .HasColumnType("TEXT");
                    b.Property<string>("Local")
                        .HasColumnType("TEXT");
                    b.Property<string>("Lote")
                        .HasColumnType("TEXT");
                    b.Property<int>("QtdPessoas")
                        .HasColumnType("INTEGER");
                    b.Property<string>("Tema")
                        .HasColumnType("TEXT");
                    b.HasKey("EventoId");
                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}