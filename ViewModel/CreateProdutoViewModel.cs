namespace PolimedicaSite.ViewModel
{
    public class CreateProdutoViewModel
    {
        public string NomeProduto {  get; set; }
        public string Descricao {  get; set; }
        public string? Detalhes { get; set; }
        public Boolean? Ativo { get; set; }
        public long? Preco { get; set; }
        public int? Estoque {  get; set; }
        public DateOnly? DataCadastro { get; set; }
        public string? Imagem1 { get; set; }
        public string? Imagem2 { get; set; }
        public string? Imagem3 { get; set; }
        public string? Imagem4 { get; set; }
        public string? Imagem5 { get; set; }
    }
}
