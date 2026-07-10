# CampusExpress - 校园快递驿站管理系统

基于 C# WinForms + SQL Server 的校园快递驿站管理解决方案，采用经典三层架构（UI / BLL / DAL）实现高内聚低耦合。

## 技术栈

- 前端界面：C# WinForms
- 后端框架：.NET Framework 
- 数据库：SQL Server 
- 架构模式：三层架构（表示层 UI / 业务逻辑层 BLL / 数据访问层 DAL）
- 开发工具：Visual Studio 2022

## 功能模块（14个窗体）

| 模块 | 窗体 | 对应BLL/DAL | 功能说明 |
|-----|------|------------|---------|
| 用户登录 | Frmlogin | AdminInfoBLL/DAL | 登录验证、验证码、MD5加密 |
| 主控台 | FrmMain | — | 系统主界面、功能导航 |
| 学生管理 | FrmStudentManage | StudentInfoBLL/DAL | 学生信息增删改查 |
| 管理员管理 | FrmAdminManage | AdminInfoBLL/DAL | 管理员权限与账号管理 |
| 个人中心 | FrmPersonal | StudentInfoBLL/DAL | 用户个人信息查看与修改 |
| 包裹管理 | FrmPackageManage | ExpressPackageBLL/DAL | 快递包裹入库、状态更新 |
| 我的包裹 | FrmMyPackage | ExpressPackageBLL/DAL | 用户查看自己的快递 |
| 寄件管理 | FrmSendManage | SendRecordBLL/DAL | 寄件登记、寄件单管理 |
| 我的寄件 | FrmMySend | SendRecordBLL/DAL | 用户查看自己的寄件记录 |
| 取件管理 | FrmPickup | ExpressPackageBLL/DAL | 取件确认、签收记录 |
| 货架管理 | FrmShelfManage | ShelfInfoBLL/DAL | 货架分区、快递上架管理 |
| 分类管理 | FrmCategoryManage | ExpressCategoryBLL/DAL | 包裹分类、类型管理 |
| 通知管理 | FrmNoticeManage | SystemNoticeBLL/DAL | 系统通知、公告发布 |
| 数据统计 | FrmStatistics | ExpressPackageBLL/DAL | 包裹量/寄件量/取件量统计 |

## 系统架构

- **UI 表示层**（WinForms）：14个窗体，用户交互
  - Frmlogin, FrmMain, FrmStudentManage, FrmPackageManage...
- **BLL 业务逻辑层**：业务规则、数据校验
  - AdminInfoBLL, StudentInfoBLL, ExpressPackageBLL, SendRecordBLL, ShelfInfoBLL, ExpressCategoryBLL, SystemNoticeBLL
- **DAL 数据访问层**：SQL操作、数据库连接
  - AdminInfoDAL, StudentInfoDal, ExpressPackageDAL, SendRecordDAL, ShelfInfoDAL, ExpressCategoryDAL, SystemNoticeDAL, DBHelper
- **数据库**：SQL Server（ExpressManager）
  - 用户表、包裹表、寄件记录表、货架表、分类表、通知表

## 项目结构

**Express.UI** - 表示层（14个窗体 + 辅助类）
- Frmlogin.cs, FrmMain.cs
- FrmStudentManage.cs, FrmAdminManage.cs, FrmPersonal.cs
- FrmPackageManage.cs, FrmMyPackage.cs
- FrmSendManage.cs, FrmMySend.cs, FrmPickup.cs
- FrmShelfManage.cs, FrmCategoryManage.cs
- FrmNoticeManage.cs, FrmStatistics.cs
- CaptchaHelper.cs, MD5Helper.cs, Global.cs, Program.cs

**Express.BLL** - 业务逻辑层
- AdminInfoBLL.cs, StudentInfoBLL.cs
- ExpressPackageBLL.cs, SendRecordBLL.cs
- ShelfInfoBLL.cs, ExpressCategoryBLL.cs
- SystemNoticeBLL.cs

**Express.DAL** - 数据访问层
- AdminInfoDAL.cs, StudentInfoDal.cs
- ExpressPackageDAL.cs, SendRecordDAL.cs
- ShelfInfoDAL.cs, ExpressCategoryDAL.cs
- SystemNoticeDAL.cs, DBHelper.cs

**Express.Model** - 实体类
- AdminInfo.cs, StudentInfo.cs
- ExpressPackage.cs, SendRecord.cs
- ShelfInfo.cs, ExpressCategory.cs
- SystemNotice.cs

**配置文件**
- App.config
## 核心设计亮点

- 经典三层架构：UI/BLL/DAL严格分离，层与层通过Model实体类传递数据，便于维护和扩展
- 统一数据访问：DBHelper封装ADO.NET操作，集中管理数据库连接，支持参数化查询
- 安全机制：登录模块采用MD5加密 + 验证码双重验证，防止暴力破解
- 模块化设计：14个窗体按功能模块划分，BLL/DAL一一对应，代码结构清晰
- 实体类映射：Express.Model定义完整实体，实现面向对象的数据操作
## 运行截图
（截图待补充）

## 运行说明

1. 克隆本仓库
2. 用Visual Studio 2022打开 `Express.UI.sln`
3. 在SQL Server中创建 `ExpressManager` 数据库，执行项目中的建表脚本
4. 修改 `Express.DAL/DBHelper.cs` 中的连接字符串
5. 按F5运行项目

## 项目背景

基于 C# WinForms + SQL Server 的校园快递驿站管理解决方案，采用经典三层架构实现高内聚低耦合。

## 未来方向

基于本系统的业务逻辑，正在探索将传统三层架构与AI Agent结合，构建面向校园场景的主动服务Agent（多Agent协同架构）。

## 作者

- 独立开发
- 课程设计项目
