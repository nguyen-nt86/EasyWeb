using EasyWeb.Model;
using Microsoft.EntityFrameworkCore;
using Attribute = EasyWeb.Model.Attribute;

namespace EasyWeb.Data
{
    public partial class EasyWebContext : DbContext
    {
        public EasyWebContext()
        {
        }

        public EasyWebContext(DbContextOptions<EasyWebContext> options)
            : base(options)
        {
        }



        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Attribute> Attribute { get; set; }
        public virtual DbSet<AttributeGroup> AttributeGroup { get; set; }
        public virtual DbSet<AttributeGroupDetails> AttributeGroupDetails { get; set; }
        public virtual DbSet<AttributeType> AttributeType { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<DateTimeAttributeValue> DateTimeAttributeValue { get; set; }
        public virtual DbSet<DecimalAttributeValue> DecimalAttributeValue { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Entity> Entity { get; set; }
        public virtual DbSet<EntityDetails> EntityDetails { get; set; }
        public virtual DbSet<NumberAttributeValue> NumberAttributeValue { get; set; }
        public virtual DbSet<OptionAttributeValue> OptionAttributeValue { get; set; }
        public virtual DbSet<StringAttributeValue> StringAttributeValue { get; set; }
        public virtual DbSet<TextAttributeValue> TextAttributeValue { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<Ward> Ward { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=(local);Database=Nguyen;uid=sa;pwd=Admin@123;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasIndex(e => e.Username)
                    .HasName("IX_Account")
                    .IsUnique();

                entity.Property(e => e.AccountId).ValueGeneratedNever();

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.AddressId).ValueGeneratedNever();

                entity.Property(e => e.Address1).HasColumnName("Address");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Address_City");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Address_District");

                entity.HasOne(d => d.UserProfile)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.UserProfileId)
                    .HasConstraintName("FK_Address_UserProfile");

                entity.HasOne(d => d.Ward)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.WardId)
                    .HasConstraintName("FK_Address_Ward");
            });

            modelBuilder.Entity<Attribute>(entity =>
            {
                entity.Property(e => e.AttributeId).ValueGeneratedNever();

                entity.Property(e => e.AttributeName).HasMaxLength(50);

                entity.HasOne(d => d.AttributeType)
                    .WithMany(p => p.Attribute)
                    .HasForeignKey(d => d.AttributeTypeId)
                    .HasConstraintName("FK_Attribute_AttributeType");
            });

            modelBuilder.Entity<AttributeGroup>(entity =>
            {
                entity.Property(e => e.AttributeGroupId).ValueGeneratedNever();

                entity.Property(e => e.AttributeGroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<AttributeGroupDetails>(entity =>
            {
                entity.HasKey(e => new { e.AttributeGroupId, e.AttributeId });

                entity.HasOne(d => d.AttributeGroup)
                    .WithMany(p => p.AttributeGroupDetails)
                    .HasForeignKey(d => d.AttributeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttributeGroupDetails_AttributeGroup");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.AttributeGroupDetails)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttributeGroupDetails_Attribute");
            });

            modelBuilder.Entity<AttributeType>(entity =>
            {
                entity.Property(e => e.AttributeTypeId).ValueGeneratedNever();

                entity.Property(e => e.AttributeDescription).HasMaxLength(100);

                entity.Property(e => e.AttributeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).ValueGeneratedNever();

                entity.Property(e => e.CityName).HasMaxLength(50);
            });

            modelBuilder.Entity<DateTimeAttributeValue>(entity =>
            {
                entity.HasKey(e => e.ValueId);

                entity.ToTable("DateTime_AttributeValue");

                entity.Property(e => e.ValueId).ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnType("datetime");

                entity.HasOne(d => d.ValueNavigation)
                    .WithOne(p => p.DateTimeAttributeValue)
                    .HasForeignKey<DateTimeAttributeValue>(d => d.ValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DateTime_AttributeValue_Attribute");
            });

            modelBuilder.Entity<DecimalAttributeValue>(entity =>
            {
                entity.HasKey(e => e.ValueId)
                    .HasName("PK_Decimal_Attribute");

                entity.ToTable("Decimal_AttributeValue");

                entity.Property(e => e.ValueId).ValueGeneratedNever();

                entity.Property(e => e.Value).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ValueNavigation)
                    .WithOne(p => p.DecimalAttributeValue)
                    .HasForeignKey<DecimalAttributeValue>(d => d.ValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Decimal_Attribute_Attribute");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.DistrictId).ValueGeneratedNever();

                entity.Property(e => e.DistrictName).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_District_City");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.Property(e => e.EntityId).ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EntityName).HasMaxLength(100);

                entity.Property(e => e.Modified).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Entity)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Entity_Category");
            });

            modelBuilder.Entity<EntityDetails>(entity =>
            {
                entity.HasKey(e => new { e.EntityId, e.AttributeGroupId });

                entity.HasOne(d => d.AttributeGroup)
                    .WithMany(p => p.EntityDetails)
                    .HasForeignKey(d => d.AttributeGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntityDetails_AttributeGroup");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.EntityDetails)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntityDetails_Entity");
            });

            modelBuilder.Entity<NumberAttributeValue>(entity =>
            {
                entity.HasKey(e => e.ValueId);

                entity.ToTable("Number_AttributeValue");

                entity.Property(e => e.ValueId).ValueGeneratedNever();

                entity.HasOne(d => d.ValueNavigation)
                    .WithOne(p => p.NumberAttributeValue)
                    .HasForeignKey<NumberAttributeValue>(d => d.ValueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Number_AttributeValue_Attribute");
            });

            modelBuilder.Entity<OptionAttributeValue>(entity =>
            {
                entity.HasKey(e => e.ValueId);

                entity.ToTable("Option_AttributeValue");

                entity.Property(e => e.ValueId).ValueGeneratedNever();

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.OptionAttributeValue)
                    .HasForeignKey(d => d.AttributeId)
                    .HasConstraintName("FK_Option_AttributeValue_Attribute");
            });

            modelBuilder.Entity<StringAttributeValue>(entity =>
            {
                entity.HasKey(e => e.ValueId);

                entity.ToTable("String_AttributeValue");

                entity.Property(e => e.ValueId).ValueGeneratedNever();

                entity.Property(e => e.Value).HasMaxLength(255);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.StringAttributeValue)
                    .HasForeignKey(d => d.AttributeId)
                    .HasConstraintName("FK_String_AttributeValue_Attribute");
            });

            modelBuilder.Entity<TextAttributeValue>(entity =>
            {
                entity.HasKey(e => e.ValueId);

                entity.ToTable("Text_AttributeValue");

                entity.Property(e => e.ValueId).ValueGeneratedNever();

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.TextAttributeValue)
                    .HasForeignKey(d => d.AttributeId)
                    .HasConstraintName("FK_Text_AttributeValue_Attribute");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.Property(e => e.UserProfileId).ValueGeneratedNever();

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_UserProfile_Account");
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.Property(e => e.WardId).ValueGeneratedNever();

                entity.Property(e => e.WardName).HasMaxLength(50);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.Ward)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_Ward_District");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
