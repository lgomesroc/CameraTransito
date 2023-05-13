using IronOcr;
using System;

namespace CameraTransito.Contramao
{
	public class Contramao
	{
		public Contramao() { }

		public Contramao(int id) { }
		public string[] receberFotosVeiculos()
		{
			var fotosveiculos = new IronTesseract();

			string[] placas = new string[3];

			fotosveiculos.Language = OcrLanguage.Portuguese;

			using (var input01 = new OcrInput())
			{
				input01.AddImage(@"D:\placas de carros para realizar testes\placa antiga 01.jpg");
				OcrResult result = fotosveiculos.Read(input01);
				Console.WriteLine(result.Text);
				placas[0] = result.Text;
			}

			using (var input02 = new OcrInput())
			{
				input02.AddImage(@"D:\placas de carros para realizar testes\placa antiga 02.jpg");
				OcrResult result = fotosveiculos.Read(input02);
				Console.WriteLine(result.Text);
				placas[1] = result.Text;
			}

			using (var input03 = new OcrInput())
			{
				input03.AddImage(@"D:\placas de carros para realizar testes\placa mercosul 01.jpg");
				OcrResult result = fotosveiculos.Read(input03);
				Console.WriteLine(result.Text);
				placas[2] = result.Text;
			}

			using (var input04 = new OcrInput())
			{
				input04.AddImage(@"D:\placas de carros para realizar testes\placa mercosul 02.jpg");
				OcrResult result = fotosveiculos.Read(input04);
				Console.WriteLine(result.Text);
				placas[3] = result.Text;
			}

			return placas;
		}
		
		public Dictionary<int, string> verificarInfracao(string placas)
		{
			Dictionary<int, string> placasinfracao = new Dictionary<int, string>();

			foreach(var item in placas)
			{

				placasinfracao = //aqui conectar ao banco de dados para verificar se o veículo é ou não autorizado e salvar no dicionário.

				if //vamos verificar se é autorizado
					placasinfracao[].Remove;
			}
			return placasinfracao;
		}
	}
}