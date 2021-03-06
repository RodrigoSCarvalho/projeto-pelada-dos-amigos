// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Proj_Pelada_Dos_Amigos.Models;

#nullable disable

namespace Proj_Pelada_Dos_Amigos.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Proj_Pelada_Dos_Amigos.Models.Jogador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("poteId")
                        .HasColumnType("integer");

                    b.Property<int>("timeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("poteId");

                    b.HasIndex("timeId");

                    b.ToTable("Jogadores");
                });

            modelBuilder.Entity("Proj_Pelada_Dos_Amigos.Models.Pote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Potes");
                });

            modelBuilder.Entity("Proj_Pelada_Dos_Amigos.Models.Time", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Times");
                });

            modelBuilder.Entity("Proj_Pelada_Dos_Amigos.Models.Jogador", b =>
                {
                    b.HasOne("Proj_Pelada_Dos_Amigos.Models.Pote", "pote")
                        .WithMany()
                        .HasForeignKey("poteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proj_Pelada_Dos_Amigos.Models.Time", "time")
                        .WithMany()
                        .HasForeignKey("timeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pote");

                    b.Navigation("time");
                });
#pragma warning restore 612, 618
        }
    }
}
