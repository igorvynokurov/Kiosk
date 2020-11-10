﻿// <auto-generated />
using System;
using KioskBrains.Server.Domain.Entities.DbStorage;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KioskBrains.Server.Domain.Migrations
{
    [DbContext(typeof(KioskBrainsContext))]
    [Migration("20201109235956_customer")]
    partial class customer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasMaxLength(255);

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(255);

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<int?>("CountryId");

                    b.Property<int?>("StateId");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.CentralBankExchangeRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DefaultOrder");

                    b.Property<string>("ForeignCurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("LocalCurrencyCode")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("CentralBankExchangeRates");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.CentralBankExchangeRateUpdate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CentralBankExchangeRateId");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(19,6)");

                    b.Property<DateTime>("StartTime");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CentralBankExchangeRateId");

                    b.ToTable("CentralBankExchangeRateUpdates");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alpha2")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Alpha3")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsSystem");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("SupportPhone")
                        .HasMaxLength(50);

                    b.Property<string>("TimeZoneName")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.DbPersistentCacheItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Value");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.ToTable("DbPersistentCacheItems");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.EK.EkImageCacheItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageKey")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("ImageUrl");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("ImageKey")
                        .IsUnique();

                    b.ToTable("EkImageCacheItems");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.EK.EkTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedOnUtc");

                    b.Property<int?>("CompletionStatus");

                    b.Property<string>("CustomerInfoJson");

                    b.Property<string>("DeliveryInfoJson");

                    b.Property<bool>("IsSentToEkSystem");

                    b.Property<int>("KioskId");

                    b.Property<DateTime>("LocalEndedOn");

                    b.Property<DateTime>("LocalStartedOn");

                    b.Property<DateTime?>("NextSendingToEkTimeUtc");

                    b.Property<string>("ProductsJson");

                    b.Property<string>("PromoCode")
                        .HasMaxLength(20);

                    b.Property<string>("ReceiptNumber")
                        .HasMaxLength(50);

                    b.Property<int>("Status");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(19,2)");

                    b.Property<string>("TotalPriceCurrencyCode")
                        .HasMaxLength(3);

                    b.Property<string>("UniqueId")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("KioskId");

                    b.HasIndex("LocalStartedOn");

                    b.HasIndex("CompletionStatus", "IsSentToEkSystem", "NextSendingToEkTimeUtc");

                    b.ToTable("EkTransactions");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.IntegrationLogRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Direction");

                    b.Property<string>("ExternalSystem")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<TimeSpan>("ProcessingTime");

                    b.Property<string>("Request");

                    b.Property<DateTime>("RequestedOnUtc");

                    b.Property<string>("Response");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("ExternalSystem");

                    b.HasIndex("RequestedOnUtc");

                    b.ToTable("IntegrationLogRecords");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.Kiosk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId");

                    b.Property<string>("AdminModePassword")
                        .HasMaxLength(8);

                    b.Property<int>("ApplicationType");

                    b.Property<string>("AssignedKioskVersion")
                        .HasMaxLength(50);

                    b.Property<string>("CommaSeparatedLanguageCodes")
                        .HasMaxLength(255);

                    b.Property<string>("CommunicationComments")
                        .HasMaxLength(1000);

                    b.Property<int?>("CurrentStateId");

                    b.Property<int>("CustomerId");

                    b.Property<DateTime?>("LastPingedOnUtc");

                    b.Property<string>("SerialKey")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("Status");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("WorkflowComponentConfigurationsJson")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("CurrentStateId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SerialKey")
                        .IsUnique();

                    b.ToTable("Kiosks");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.KioskState", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KioskVersion")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LocalTime");

                    b.Property<DateTime>("TimeUtc");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("KioskStates");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.KioskStateComponentInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ComponentName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("KioskStateId");

                    b.Property<string>("SpecificMonitorableStateJson");

                    b.Property<int>("StatusCode");

                    b.Property<string>("StatusMessage");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("KioskStateId");

                    b.ToTable("KioskStateComponentInfos");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.KioskVersionUpdate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicationType");

                    b.Property<string>("ReleaseNotes");

                    b.Property<string>("UpdateUrl")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("VersionName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("VersionName")
                        .IsUnique();

                    b.ToTable("KioskVersionUpdates");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.LogRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalDataJson");

                    b.Property<int>("Context");

                    b.Property<int>("KioskId");

                    b.Property<string>("KioskVersion")
                        .HasMaxLength(50);

                    b.Property<DateTime>("LocalTime");

                    b.Property<string>("Message");

                    b.Property<int>("Type");

                    b.Property<string>("UniqueId")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("Context");

                    b.HasIndex("KioskId");

                    b.HasIndex("LocalTime");

                    b.HasIndex("Type");

                    b.ToTable("LogRecords");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.NotificationCallbackLogRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Channel")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("MessageJson");

                    b.Property<DateTime>("ReceivedOnUtc");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("NotificationCallbackLogRecords");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.NotificationReceiver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Channel");

                    b.Property<int>("CustomerId");

                    b.Property<int>("NotificationType");

                    b.Property<string>("ReceiverId")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("NotificationReceivers");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.PortalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Role");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("PortalUsers");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<int>("CountryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.Address", b =>
                {
                    b.HasOne("KioskBrains.Server.Domain.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("KioskBrains.Server.Domain.Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId");
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.CentralBankExchangeRateUpdate", b =>
                {
                    b.HasOne("KioskBrains.Server.Domain.Entities.CentralBankExchangeRate", "CentralBankExchangeRate")
                        .WithMany("CentralBankExchangeRateUpdates")
                        .HasForeignKey("CentralBankExchangeRateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.EK.EkTransaction", b =>
                {
                    b.HasOne("KioskBrains.Server.Domain.Entities.Kiosk", "Kiosk")
                        .WithMany()
                        .HasForeignKey("KioskId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.Kiosk", b =>
                {
                    b.HasOne("KioskBrains.Server.Domain.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("KioskBrains.Server.Domain.Entities.KioskState", "CurrentState")
                        .WithMany()
                        .HasForeignKey("CurrentStateId");

                    b.HasOne("KioskBrains.Server.Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.KioskStateComponentInfo", b =>
                {
                    b.HasOne("KioskBrains.Server.Domain.Entities.KioskState", "KioskState")
                        .WithMany("ComponentsStatuses")
                        .HasForeignKey("KioskStateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.LogRecord", b =>
                {
                    b.HasOne("KioskBrains.Server.Domain.Entities.Kiosk", "Kiosk")
                        .WithMany()
                        .HasForeignKey("KioskId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.NotificationReceiver", b =>
                {
                    b.HasOne("KioskBrains.Server.Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.PortalUser", b =>
                {
                    b.HasOne("KioskBrains.Server.Domain.Entities.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("KioskBrains.Server.Domain.Entities.State", b =>
                {
                    b.HasOne("KioskBrains.Server.Domain.Entities.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
