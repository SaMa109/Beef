﻿global using CoreEx;
global using CoreEx.Entities;
global using CoreEx.Http;
global using CoreEx.RefData;
global using CoreEx.Validation;
global using CoreEx.WebApis;
global using Microsoft.AspNetCore.Mvc;
#if (implement_cosmos)
global using AzCosmos = Microsoft.Azure.Cosmos;
#endif
global using Microsoft.Extensions.Caching.Memory;
global using Microsoft.OpenApi.Models;
global using System.Net;
global using System.Reflection;
global using Cdr.Banking.Business;
global using Cdr.Banking.Business.Data;
global using Cdr.Banking.Business.Entities;
global using RefDataNamespace = Cdr.Banking.Business.Entities;