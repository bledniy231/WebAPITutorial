﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebAPITutorial.DBContexts;

#nullable disable

namespace WebAPITutorial.Migrations
{
    [DbContext(typeof(KucoinVolContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebAPITutorial.Models.KucoinVolatilityEntity+ARB_USDT_Item", b =>
                {
                    b.Property<long>("KucoinVolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("KucoinVolId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.Property<double>("QuoteVolume")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.HasKey("KucoinVolId");

                    b.ToTable("ARB_USDT_Items");
                });

            modelBuilder.Entity("WebAPITutorial.Models.KucoinVolatilityEntity+BNB_USDT_Item", b =>
                {
                    b.Property<long>("KucoinVolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("KucoinVolId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.Property<double>("QuoteVolume")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.HasKey("KucoinVolId");

                    b.ToTable("BNB_USDT_Items");
                });

            modelBuilder.Entity("WebAPITutorial.Models.KucoinVolatilityEntity+BTC_USDT_Item", b =>
                {
                    b.Property<long>("KucoinVolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("KucoinVolId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.Property<double>("QuoteVolume")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.HasKey("KucoinVolId");

                    b.ToTable("BTC_USDT_Items");
                });

            modelBuilder.Entity("WebAPITutorial.Models.KucoinVolatilityEntity+DOGE_USDT_Item", b =>
                {
                    b.Property<long>("KucoinVolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("KucoinVolId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.Property<double>("QuoteVolume")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.HasKey("KucoinVolId");

                    b.ToTable("DOGE_USDT_Items");
                });

            modelBuilder.Entity("WebAPITutorial.Models.KucoinVolatilityEntity+ETH_USDT_Item", b =>
                {
                    b.Property<long>("KucoinVolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("KucoinVolId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.Property<double>("QuoteVolume")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.HasKey("KucoinVolId");

                    b.ToTable("ETH_USDT_Items");
                });

            modelBuilder.Entity("WebAPITutorial.Models.KucoinVolatilityEntity+LTC_USDT_Item", b =>
                {
                    b.Property<long>("KucoinVolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("KucoinVolId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.Property<double>("QuoteVolume")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.HasKey("KucoinVolId");

                    b.ToTable("LTC_USDT_Items");
                });

            modelBuilder.Entity("WebAPITutorial.Models.KucoinVolatilityEntity+MATIC_USDT_Item", b =>
                {
                    b.Property<long>("KucoinVolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("KucoinVolId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.Property<double>("QuoteVolume")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.HasKey("KucoinVolId");

                    b.ToTable("MATIC_USDT_Items");
                });

            modelBuilder.Entity("WebAPITutorial.Models.KucoinVolatilityEntity+SOL_USDT_Item", b =>
                {
                    b.Property<long>("KucoinVolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("KucoinVolId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.Property<double>("QuoteVolume")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.HasKey("KucoinVolId");

                    b.ToTable("SOL_USDT_Items");
                });

            modelBuilder.Entity("WebAPITutorial.Models.KucoinVolatilityEntity+UNI_USDT_Item", b =>
                {
                    b.Property<long>("KucoinVolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("KucoinVolId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.Property<double>("QuoteVolume")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.HasKey("KucoinVolId");

                    b.ToTable("UNI_USDT_Items");
                });

            modelBuilder.Entity("WebAPITutorial.Models.KucoinVolatilityEntity+XRP_USDT_Item", b =>
                {
                    b.Property<long>("KucoinVolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("KucoinVolId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.Property<double>("QuoteVolume")
                        .HasPrecision(18, 10)
                        .HasColumnType("double precision");

                    b.HasKey("KucoinVolId");

                    b.ToTable("XRP_USDT_Items");
                });
#pragma warning restore 612, 618
        }
    }
}
