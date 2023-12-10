﻿using AutoMapper;
using FM_MyStat_API.Core.DTOs.HomeworksDTO;
using FM_MyStat_API.Core.DTOs.HomeworksDTO.Homework;
using FM_MyStat_API.Core.DTOs.UsersDTO.User;
using FM_MyStat_API.Core.Entities.Homeworks;
using FM_MyStat_API.Core.Entities.Lessons;
using FM_MyStat_API.Core.Entities.Specifications;
using FM_MyStat_API.Core.Entities.Users;
using FM_MyStat_API.Core.Interfaces;
using FM_MyStat_API.Core.Services.Users;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM_MyStat_API.Core.Services.HomeworkServices
{
    public class HomeworkDoneService : IHomeworkDoneService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<HomeworkDone> _homeworkDoneRepo;
        private readonly IRepository<Homework> _homeworkRepo;
        private readonly IRepository<Student> _studentRepo;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IConfiguration _configuration;
        private readonly UserService _userService;

        public HomeworkDoneService(IMapper mapper, UserService userService, IRepository<HomeworkDone> homeRepo, IWebHostEnvironment webHostEnvironment, IConfiguration configuration, IRepository<Student> studentRepo)
        {
            _userService = userService;
            _homeworkDoneRepo = homeRepo;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
            _configuration = configuration;
            _studentRepo = studentRepo;
        }

        public async Task Create(HomeworkDoneDTO model)
        {

            if (model.File != null)
            {
                string wevRootPath = _webHostEnvironment.WebRootPath;
                string uploadt = wevRootPath + _configuration.GetValue<string>("FileSettings2:FilePath");
                var files = model.File;
                var fileName = Guid.NewGuid().ToString();
                string extansions = Path.GetExtension(files[0].FileName);
                using (var fileStream = new FileStream(Path.Combine(uploadt, fileName + extansions), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                model.FilePath = fileName + extansions;
            }
            else
            {
                model.FilePath = "Default.txt";
            }
            HomeworkDone addedHomework = _mapper.Map<HomeworkDoneDTO, HomeworkDone>(model);
            
            await _homeworkDoneRepo.Insert(addedHomework);
            await _homeworkDoneRepo.Save();

            //await _homeworkDoneRepo.Insert(_mapper.Map<HomeworkDone>(model));
            //await _homeworkDoneRepo.Save();
        }

        public async Task Delete(int id)
        {
            var model = await Get(id);
            if (model == null) return;

            await _homeworkDoneRepo.Delete(model.Id);
            await _homeworkDoneRepo.Save();
        }

        public async Task<HomeworkDoneDTO?> Get(int id)
        {
            if (id < 0) return null;
            var category = await _homeworkDoneRepo.GetByID(id);
            if (category == null) return null;
            return _mapper.Map<HomeworkDoneDTO?>(category);

        }

        public async Task<List<HomeworkDoneDTO>> GetAll()
        {
            var result = await _homeworkDoneRepo.GetAll();
            return _mapper.Map<List<HomeworkDoneDTO>>(result);
        }

        public async Task<List<HomeworkDoneDTO>> GetAll(int homeworkId)
        {
            var result = await _homeworkDoneRepo.GetAll();
            var filteredHomeworkDones = result.Where(h => h.HomeworkId == homeworkId);
            ServiceResponse<List<UserDTO>, object> serviceResponse = await this._userService.GetAllAsync();
            List<UserDTO> userDTOs = serviceResponse.Payload.Where(u => u.Role == "Student").ToList();
            
            var map = _mapper.Map<List<HomeworkDoneDTO>>(filteredHomeworkDones);
            foreach (var item in map)
            {
                foreach (var item2 in userDTOs)
                {
                    if (item.StudentId == item2.StudentId)
                    {
                        item.FullNameStudent = $"{item2.FirstName} {item2.SurName} {item2.LastName}";
                    }
                }
            }

            return map;
        }


        public async Task<ServiceResponse> GetByName(HomeworkDoneDTO model)
        {
            var result = await _homeworkDoneRepo.GetItemBySpec(new HomeworkDoneSpecification.GetByDescription(model.Description));
            if (result != null)
            {
                return new ServiceResponse
                {
                    Success = false,
                    Message = "HomeworkDone exists."
                };
            }
            var category = _mapper.Map<HomeworkDoneDTO>(result);
            return new ServiceResponse
            {
                Success = true,
                Message = "HomeworkDone successfully loaded.",
                Payload = category
            };
        }

        public async Task<HomeworkDoneDTO> GetByName(string Description)
        {
            var result = await _homeworkDoneRepo.GetItemBySpec(new HomeworkDoneSpecification.GetByDescription(Description));
            if (result != null)
            {
                HomeworkDoneDTO categoryDTO = _mapper.Map<HomeworkDoneDTO>(result);
                return categoryDTO;
            }
            return null;
        }

        public async Task Update(HomeworkDoneDTO model)
        {
            await _homeworkDoneRepo.Update(_mapper.Map<HomeworkDone>(model));
            await _homeworkDoneRepo.Save();
        }

        public async Task<(byte[] fileContents, string contentType, string fileName)> DownloadHomeworkFileAsync(int homeworkId)
        {
            var homework = await _homeworkDoneRepo.GetByID(homeworkId);
            if (homework == null)
            {
                return (null, null, null);
            }

            string webPathRoot = _webHostEnvironment.WebRootPath;
            string upload = webPathRoot + _configuration.GetValue<string>("FileSettings2:FilePath");

            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, upload, homework.FilePath);

            filePath = Path.GetFullPath(filePath);


            if (!System.IO.File.Exists(filePath))
            {
                return (null, null, null);
            }

            byte[] fileContents = await System.IO.File.ReadAllBytesAsync(filePath);
            string contentType = "application/octet-stream";
            string fileName = Path.GetFileName(filePath);

            return (fileContents, contentType, fileName);
        }

    }
}