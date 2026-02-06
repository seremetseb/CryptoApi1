# CryptoApi1 – CI/CD API i C#

Detta projekt är ett enkelt REST-API byggt i C# med ASP.NET Core (Minimal API).
API:t erbjuder funktionalitet för kryptering och dekryptering av text med ett
enkelt Caesar-chiffer.

Projektets syfte är att visa ett fungerande CI/CD-flöde med GitHub Actions och
publicering till AWS Elastic Beanstalk.

---

Live API (AWS)
API:t är publicerat och körs i AWS Elastic Beanstalk:


http://cryptoapi1-env.eba-un35wvpm.eu-north-1.elasticbeanstalk.com/




Health check-endpoint som används för att verifiera att API:t kör korrekt.

Svar: Ok

Krypterar inskickad text med ett Caesar-chiffer (skift +3).

Request body:
```json
{
  "text": "Hello World"
}

Svar:

{
  "result": "Khoor Zruog"
}

