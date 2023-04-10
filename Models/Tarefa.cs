//conjunto de classes
namespace GerenciaTarefa.Models;
//conjunto de objetos
public class Tarefa{

  //classe é um conjunto de objetos
  //Propriedades Automáticas
  public int Id { get; set; } //inteiro

  public String? Cabeclho { get; set; }

  public string? Titulo { get; set; }
  public string? Descricao { get; set; } //texto
  
  public bool TaCompleta { get; set; }
  //Funcionalidades

}