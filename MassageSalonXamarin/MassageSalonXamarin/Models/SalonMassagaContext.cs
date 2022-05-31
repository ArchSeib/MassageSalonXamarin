using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Text;

namespace MassageSalonXamarin.Models
{
    public partial class SalonMassagaContext : DbContext
    {
        public SalonMassagaContext()
        {
        }

        public SalonMassagaContext(DbContextOptions<SalonMassagaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<MessageSalon> MessageSalons { get; set; } = null!;
        public virtual DbSet<Obonement> Obonements { get; set; } = null!;
        public virtual DbSet<Post> Posts { get; set; } = null!;
        public virtual DbSet<ReceptionLife> ReceptionLives { get; set; } = null!;
        public virtual DbSet<ReceptionOnline> ReceptionOnlines { get; set; } = null!;
        public virtual DbSet<Sender> Senders { get; set; } = null!;
        public virtual DbSet<Service> Services { get; set; } = null!;
        public virtual DbSet<Shedule> Shedules { get; set; } = null!;
        public virtual DbSet<Shift> Shifts { get; set; } = null!;
        public virtual DbSet<Worker> Workers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=ArchSeib;Initial Catalog=SalonMassaga;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.Idclients)
                    .HasName("PK_Клиент");

                entity.Property(e => e.Idclients).HasColumnName("IDClients");

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Login).HasMaxLength(30);

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.Vk)
                    .HasMaxLength(30)
                    .HasColumnName("VK");
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.HasKey(e => e.Idakcii)
                    .HasName("PK_Акции");

                entity.ToTable("Event");

                entity.Property(e => e.Idakcii).HasColumnName("IDAkcii");

                entity.Property(e => e.Idservices).HasColumnName("IDServices");

                entity.Property(e => e.NameAkcii).HasMaxLength(30);

                entity.Property(e => e.OpisanieAkcii).HasColumnType("text");

                entity.Property(e => e.TimeLiveAkcii).HasMaxLength(50);

                entity.HasOne(d => d.IdservicesNavigation)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.Idservices)
                    .HasConstraintName("FK_Event_Service");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasKey(e => e.Idfeedback);

                entity.ToTable("Feedback");

                entity.Property(e => e.Idfeedback).HasColumnName("IDFeedback");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Idclients).HasColumnName("IDClients");

                entity.Property(e => e.Text).HasColumnType("text");

                entity.HasOne(d => d.IdclientsNavigation)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.Idclients)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_Clients");
            });

            modelBuilder.Entity<MessageSalon>(entity =>
            {
                entity.HasKey(e => e.IdmessageSalon);

                entity.ToTable("MessageSalon");

                entity.Property(e => e.IdmessageSalon)
                    .ValueGeneratedNever()
                    .HasColumnName("IDMessageSalon");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Idclient).HasColumnName("IDClient");

                entity.Property(e => e.Idsender).HasColumnName("IDSender");

                entity.Property(e => e.Message).HasColumnType("text");

                entity.Property(e => e.Status).HasMaxLength(1);

                entity.HasOne(d => d.IdclientNavigation)
                    .WithMany(p => p.MessageSalons)
                    .HasForeignKey(d => d.Idclient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageSalon_Clients");

                entity.HasOne(d => d.IdsenderNavigation)
                    .WithMany(p => p.MessageSalons)
                    .HasForeignKey(d => d.Idsender)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MessageSalon_Sender");
            });

            modelBuilder.Entity<Obonement>(entity =>
            {
                entity.HasKey(e => e.Idobonement)
                    .HasName("PK_Обонемент");

                entity.ToTable("Obonement");

                entity.Property(e => e.Idobonement).HasColumnName("IDObonement");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Time).HasColumnName("TIme");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.HasKey(e => e.Idpost)
                    .HasName("PK_Должности");

                entity.ToTable("Post");

                entity.Property(e => e.Idpost)
                    .ValueGeneratedNever()
                    .HasColumnName("IDPost");

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<ReceptionLife>(entity =>
            {
                entity.HasKey(e => e.IdreceptionLife);

                entity.ToTable("ReceptionLife");

                entity.Property(e => e.IdreceptionLife).HasColumnName("IDReceptionLife");

                entity.Property(e => e.DataReceptionLife).HasColumnType("date");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Idobonement).HasColumnName("IDObonement");

                entity.Property(e => e.Idservice).HasColumnName("IDService");

                entity.Property(e => e.Idworkers).HasColumnName("IDWorkers");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.TimeReception)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdobonementNavigation)
                    .WithMany(p => p.ReceptionLives)
                    .HasForeignKey(d => d.Idobonement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceptionLife_Obonement");

                entity.HasOne(d => d.IdserviceNavigation)
                    .WithMany(p => p.ReceptionLives)
                    .HasForeignKey(d => d.Idservice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceptionLife_Service");

                entity.HasOne(d => d.IdworkersNavigation)
                    .WithMany(p => p.ReceptionLives)
                    .HasForeignKey(d => d.Idworkers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceptionLife_Workers");
            });

            modelBuilder.Entity<ReceptionOnline>(entity =>
            {
                entity.HasKey(e => e.Idreception)
                    .HasName("PK_Reception_1");

                entity.ToTable("ReceptionOnline");

                entity.Property(e => e.Idreception).HasColumnName("IDReception");

                entity.Property(e => e.DataReception).HasColumnType("date");

                entity.Property(e => e.Idclients).HasColumnName("IDClients");

                entity.Property(e => e.Idobonement).HasColumnName("IDObonement");

                entity.Property(e => e.Idservice).HasColumnName("IDService");

                entity.Property(e => e.Idworkers).HasColumnName("IDWorkers");

                entity.Property(e => e.TimeReception)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdclientsNavigation)
                    .WithMany(p => p.ReceptionOnlines)
                    .HasForeignKey(d => d.Idclients)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Приём_Клиент");

                entity.HasOne(d => d.IdobonementNavigation)
                    .WithMany(p => p.ReceptionOnlines)
                    .HasForeignKey(d => d.Idobonement)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Priem_Obinement");

                entity.HasOne(d => d.IdserviceNavigation)
                    .WithMany(p => p.ReceptionOnlines)
                    .HasForeignKey(d => d.Idservice)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Priem_Service");

                entity.HasOne(d => d.IdworkersNavigation)
                    .WithMany(p => p.ReceptionOnlines)
                    .HasForeignKey(d => d.Idworkers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Приём_Сотрудники");
            });

            modelBuilder.Entity<Sender>(entity =>
            {
                entity.HasKey(e => e.Idsender);

                entity.ToTable("Sender");

                entity.Property(e => e.Idsender).HasColumnName("IDSender");

                entity.Property(e => e.Sender1)
                    .HasMaxLength(10)
                    .HasColumnName("Sender");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.HasKey(e => e.Idservice)
                    .HasName("PK_Услуги");

                entity.ToTable("Service");

                entity.Property(e => e.Idservice).HasColumnName("IDService");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Shedule>(entity =>
            {
                entity.HasKey(e => e.Idschedule);

                entity.ToTable("Shedule");

                entity.Property(e => e.Idschedule).HasColumnName("IDSchedule");

                entity.Property(e => e.Day).HasColumnType("date");

                entity.Property(e => e.Idshift).HasColumnName("IDShift");

                entity.Property(e => e.Idworkers).HasColumnName("IDWorkers");

                entity.HasOne(d => d.IdshiftNavigation)
                    .WithMany(p => p.Shedules)
                    .HasForeignKey(d => d.Idshift)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shedule_Shift");

                entity.HasOne(d => d.IdworkersNavigation)
                    .WithMany(p => p.Shedules)
                    .HasForeignKey(d => d.Idworkers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shedule_Workers");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => e.Idshift);

                entity.ToTable("Shift");

                entity.Property(e => e.Idshift).HasColumnName("IDShift");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.NumberShift)
                    .HasMaxLength(1)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasKey(e => e.Idworkers)
                    .HasName("PK_Сотрудники");

                entity.Property(e => e.Idworkers).HasColumnName("IDWorkers");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Idpost).HasColumnName("IDPost");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Login)
                    .HasMaxLength(30)
                    .HasColumnName("login");

                entity.Property(e => e.Password).HasMaxLength(30);

                entity.Property(e => e.Patronymic).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(16);

                entity.Property(e => e.Vk)
                    .HasMaxLength(30)
                    .HasColumnName("VK");

                entity.HasOne(d => d.IdpostNavigation)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.Idpost)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Сотрудники_Должности");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
