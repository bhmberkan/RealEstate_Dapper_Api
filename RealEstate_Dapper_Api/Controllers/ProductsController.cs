﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Repositories.ProductRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }

        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }

        [HttpGet("ProductDealOfTheDayStatusChangeToTrue/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToTrue(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToTrue(id);
            return Ok("İlan Durumu Güncellendi(True)");
        }

        [HttpGet("ProductDealOfTheDayStatusChangeToFalse/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeToFalse(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeToFalse(id);
            return Ok("İlan Durumu Güncellendi(False)");
        }

        [HttpGet("Last5ProductList")]
        public async Task<IActionResult> Last5ProductList()
        {
            var values = await _productRepository.GetLast5ProductAsync();
            return Ok(values);
        }

        [HttpGet("ProductAdvertsListByEmployee")]
        public async Task<IActionResult> ProductAdvertsListByEmployee(int id)
        {
            var values = await _productRepository.GetProductAdvertsListByEmployeeAsync(id);
            return Ok(values);
        }


        [HttpGet("GetProductAdvertsListByEmployeeAsyncByTrue")]
        public async Task<IActionResult> GetProductAdvertsListByEmployeeAsyncByTrue(int id)
        {
            var values = await _productRepository.GetProductAdvertsListByEmployeeAsyncByTrue(id);
            return Ok(values);
        }


        [HttpGet("GetProductAdvertsListByEmployeeAsyncByFalse")]
        public async Task<IActionResult> GetProductAdvertsListByEmployeeAsyncByFalse(int id)
        {
            var values = await _productRepository.GetProductAdvertsListByEmployeeAsyncByFalse(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productRepository.CreateProduct(createProductDto);
            return Ok("İlan Başarıyla Eklendi");

        }

        [HttpGet("GetProductByProductId")]

        public async Task<IActionResult> GetProductByProductId(int id)
        {
            var values = await _productRepository.GetProductByProductId(id);
            return Ok(values);
        }

        [HttpGet("ResultProductWithSearchList")]
        public async Task<IActionResult> ResultProductWithSearchList(string searchKeyValue, int propertyCategoryId, string city)
        {
            var values = await _productRepository.ResultProductWithSearchList(searchKeyValue, propertyCategoryId, city);
            return Ok(values);
        }

    }
}
