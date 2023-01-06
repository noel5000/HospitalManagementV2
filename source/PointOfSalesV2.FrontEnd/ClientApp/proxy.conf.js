const { env } = require('process');

const target = env.ASPNETCORE_HTTPS_PORT ? `https://localhost:${env.ASPNETCORE_HTTPS_PORT}` :
  env.ASPNETCORE_URLS ? env.ASPNETCORE_URLS.split(';')[0] : 'http://localhost:55290';

const PROXY_CONFIG = [
  {
    context: [
      "/weatherforecast",
      "/api/login",
      "/api/category",
      "/api/company",
      "/api/customer",
      "/api/invoice",
      "/api/itemcategory",
      "/api/numbertemplate",
      "/api/product",
      "/api/user",
      "/api/warehouse",
      "/api/branchoffice",
      "/views",
      "/views/invoicePrint",
      "/invoiceprint",
    ],
    target: target,
    secure: false,
    headers: {
      Connection: 'Keep-Alive'
    }
  }
]

module.exports = PROXY_CONFIG;
