using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IProductCategoryService
    {
        void Add(ProductCategory ProductCategory);

        void Update(ProductCategory ProductCategory);

        void Delete(int id);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> GetAllPaging(int page, int pageSize, out int totalRow);

        ProductCategory GetById(int id);

        IEnumerable<ProductCategory> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _ProductCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCategoryService(IProductCategoryRepository ProductCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._ProductCategoryRepository = ProductCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(ProductCategory ProductCategory)
        {
            _ProductCategoryRepository.Add(ProductCategory);
        }

        public void Delete(int id)
        {
            _ProductCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _ProductCategoryRepository.GetAll(new string[] { "ProductCategoryCategory" });
        }

        public IEnumerable<ProductCategory> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: Select all ProductCategory by tag
            //return _ProductCategoryRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
            throw new NotImplementedException();
        }

        public IEnumerable<ProductCategory> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            //return _ProductCategoryRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
            throw new NotImplementedException();
        }

        public ProductCategory GetById(int id)
        {
            return _ProductCategoryRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategory ProductCategory)
        {
            _ProductCategoryRepository.Update(ProductCategory);
        }
    }
}