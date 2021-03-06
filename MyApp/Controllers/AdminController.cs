﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyApp.Data.Repositorys.DashBoard;
using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyApp.Controllers
{
    [Authorize("Admin")]
    public class AdminController : Controller
    {
        private readonly IWebHostEnvironment _enviorment;
        private readonly IDashBoardRepository _repository;
        private readonly ILogger<AdminController> _logger;

        public AdminController(
            IWebHostEnvironment enviorment,
            IDashBoardRepository repository,
            ILogger<AdminController> logger)
        {
            _enviorment = enviorment;
            _repository = repository;
            _logger = logger;
        }


        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// TODO: 게시판 관리자 페이지
        /// </summary>
        public IActionResult NoteManager()
        {
            return View();
        }

        public IActionResult Custom()
        {
            return View();
        }

        public IActionResult RaspServer()
        {
            return Redirect("https://jinsu-blog.iptime.org:4200/");
        }

        /// <summary>
        /// TODO: 사용자 관리자 페이지
        /// </summary>
        public IActionResult UserManager()
        {
            _logger.LogInformation("사용자 DashBoard 로딩");
            List<Log> logs = _repository.GetAllLog();

            string json = JsonSerializer.Serialize(logs);
            return View(logs);
        }

        public IActionResult ShowSql(int id )
        {
            _logger.LogInformation("저장 쿼리 조회");
            string result = _repository.getStoredSqlByid(id);
            ViewBag.sql = result;
            return View("Custom");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Custom(Log str)
        {
            Custom dataRaw = new Custom();
            List<string> dataList = new List<string>();

            dataRaw.setQuery(str.query);
            ViewBag.sql = dataRaw.getQuery();

            var result = _repository.Custom(str.query);

            // Query result check
            if (result.Contains("Error") || result.Count == 0)
            {
                if(result.Count == 0)
                    ViewBag.Status = "0 data selected";
                else
                    ViewBag.Status = result[1].ToString();

                return View();
            }

            //Get Column Name
            var buff = result[0].ToString().Split(",");
            for(int i =1; i< buff.Length; i++)
            {
                var column = (buff[i].Trim().Split(" =")[0]);
                dataRaw.setColumn(column);
            }

            //Get Raw Data 
            foreach(var item in result)
            {
                var rawData = item.ToString();

                for(int i=0; i< dataRaw.getColumnList().Count; i++)
                {
                    var columnName = dataRaw.getColumnList()[i];
                    var startIndex = rawData.IndexOf("'", rawData.IndexOf(columnName) + columnName.Length);
                    if (startIndex < 0) break;

                    var endIndex = rawData.IndexOf("'", startIndex+1);
                    var data = rawData.Substring(startIndex+1, endIndex-startIndex-1);
                    dataList.Add(data);

                    startIndex = endIndex;
                }
                dataRaw.setRaw(dataList);
                dataList.Clear();
            }

            return View(dataRaw);
        }

        [HttpPost]
        public IActionResult SaveQuery(string title, string sql)
        {
            //저장 쿼리 10개 제한
            int cnt = _repository.getSavedQueryCnt();
            if(cnt > 12)
            {
                ViewBag.status = "최대 저장 가능 개수는 12개 입니다";
                return View("Custom");
            }

            _repository.SaveQuery(title, sql);
            return View("Custom");
        }

        public IActionResult DeleteSql(int id)
        {
            _repository.DeleteSqlById(id);
            return View("Custom");
        }

        [HttpPost]
        public Object getLog(string from, string to)
        {
            List<Log> logs = _repository.GetLog(from, to);
            string json = JsonSerializer.Serialize(logs);
            return json;

        }
    }
}
