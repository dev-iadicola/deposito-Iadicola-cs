using System.Data;
using System.Runtime.CompilerServices;

namespace FirstProject.App.Entity.Base;

class Curse

{

    string nome;

    int durataH;
    string docente;
    List<string> studenti;
    public Curse(string nome, int durataH, string docente, List<string>? studenti = null)
    {
        this.nome = nome; this.durataH = durataH; this.docente = docente; this.studenti = studenti ?? new List<string>();
    }

    public void aggiungiStudente(string stu)
    {
        this.studenti.Add(stu);
    }

    public override string ToString()
    {
        return $" Nome corso: {nome}, durata: {durataH}, doc: {docente} \n";
    }
}