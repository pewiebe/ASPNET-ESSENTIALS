using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

// Trabalho para amanhâ : Instalar Depedenciais
public class AppDbContext:DbContext{

    //overrride (sobrescrever)
    //NãoTrai ( ) - Contrato
    //CompatilhaCarteira()
    //protected
    protected override void OnConfiguring(DbContextOptionsBuilder builder){
        builder.UseSqlServer("Server=LAB-F08-09;Database=EscolaDotNet;User Id=sa;Password=senai@123;TrustServer=Certificate=true");
    }

}