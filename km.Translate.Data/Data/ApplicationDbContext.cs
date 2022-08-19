﻿#nullable disable
using km.Translate.Data.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace km.Translate.Data.Data;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext()
  {
  }

  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
  {

  }

  public DbSet<Sentence> Sentences { get; set; }
  public DbSet<Language> Languages { get; set; }

  public DbSet<Proposition> Propositions { get; set; }
  public DbSet<Vote> Votes { get; set; }
  public DbSet<User> Users { get; set; }
  public DbSet<Role> Roles { get; set; }
  public DbSet<UserDetails> UserDetails { get; set; }
}
