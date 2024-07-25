using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Butce.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BudgetAmounts",
                columns: table => new
                {
                    BudgetAmountID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetAmounts", x => x.BudgetAmountID);
                });

            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    BudgetTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.BudgetTypeID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyNames",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyNames = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyNames", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelRoles = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonelState = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "VATs",
                columns: table => new
                {
                    VATID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VATRate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VATs", x => x.VATID);
                });

            migrationBuilder.CreateTable(
                name: "WorkDones",
                columns: table => new
                {
                    WorkDoneID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkDoneName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDones", x => x.WorkDoneID);
                });

            migrationBuilder.CreateTable(
                name: "WorkDoneTypes",
                columns: table => new
                {
                    WorkDoneTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkDoneTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDoneTypes", x => x.WorkDoneTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Expensess",
                columns: table => new
                {
                    ExpensesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetTypeID = table.Column<int>(type: "int", nullable: false),
                    ExpensesType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expensess", x => x.ExpensesID);
                    table.ForeignKey(
                        name: "FK_Expensess_Budgets_BudgetTypeID",
                        column: x => x.BudgetTypeID,
                        principalTable: "Budgets",
                        principalColumn: "BudgetTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddUsers",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddUsers", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_AddUsers_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proxies",
                columns: table => new
                {
                    ProxyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProxyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonelTask = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proxies", x => x.ProxyID);
                    table.ForeignKey(
                        name: "FK_Proxies_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppControls",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppControls = table.Column<bool>(type: "bit", nullable: false),
                    ExpensesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppControls", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AppControls_Expensess_ExpensesID",
                        column: x => x.ExpensesID,
                        principalTable: "Expensess",
                        principalColumn: "ExpensesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Levelss",
                columns: table => new
                {
                    LevelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpensesID = table.Column<int>(type: "int", nullable: true),
                    LevelNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Levelss", x => x.LevelID);
                    table.ForeignKey(
                        name: "FK_Levelss_Expensess_ExpensesID",
                        column: x => x.ExpensesID,
                        principalTable: "Expensess",
                        principalColumn: "ExpensesID");
                });

            migrationBuilder.CreateTable(
                name: "Refuses",
                columns: table => new
                {
                    RefuseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefuseReason = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ExpensesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refuses", x => x.RefuseID);
                    table.ForeignKey(
                        name: "FK_Refuses_Expensess_ExpensesID",
                        column: x => x.ExpensesID,
                        principalTable: "Expensess",
                        principalColumn: "ExpensesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Approvals",
                columns: table => new
                {
                    ApprovalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkDoneID = table.Column<int>(type: "int", nullable: false),
                    WorkDoneTypeID = table.Column<int>(type: "int", nullable: false),
                    VATID = table.Column<int>(type: "int", nullable: false),
                    ExcVAT = table.Column<int>(type: "int", nullable: false),
                    InVAT = table.Column<int>(type: "int", nullable: false),
                    ExpensesID = table.Column<int>(type: "int", nullable: false),
                    LevelID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Approvals", x => x.ApprovalID);
                    table.ForeignKey(
                        name: "FK_Approvals_CompanyNames_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "CompanyNames",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approvals_Expensess_ExpensesID",
                        column: x => x.ExpensesID,
                        principalTable: "Expensess",
                        principalColumn: "ExpensesID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approvals_Levelss_LevelID",
                        column: x => x.LevelID,
                        principalTable: "Levelss",
                        principalColumn: "LevelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approvals_VATs_VATID",
                        column: x => x.VATID,
                        principalTable: "VATs",
                        principalColumn: "VATID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approvals_WorkDoneTypes_WorkDoneTypeID",
                        column: x => x.WorkDoneTypeID,
                        principalTable: "WorkDoneTypes",
                        principalColumn: "WorkDoneTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Approvals_WorkDones_WorkDoneID",
                        column: x => x.WorkDoneID,
                        principalTable: "WorkDones",
                        principalColumn: "WorkDoneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plannings",
                columns: table => new
                {
                    PlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpensesID = table.Column<int>(type: "int", nullable: false),
                    BudgetAmountID = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    WorkDoneID = table.Column<int>(type: "int", nullable: false),
                    WorkDoneTypeID = table.Column<int>(type: "int", nullable: false),
                    VATID = table.Column<int>(type: "int", nullable: false),
                    ExcVAT = table.Column<int>(type: "int", nullable: false),
                    InVAT = table.Column<int>(type: "int", nullable: false),
                    PayStatus = table.Column<bool>(type: "bit", nullable: false),
                    UsableBudget = table.Column<float>(type: "real", nullable: false),
                    AvailableBudget = table.Column<float>(type: "real", nullable: false),
                    RemaningBudget = table.Column<float>(type: "real", nullable: false),
                    TotalExpenditure = table.Column<float>(type: "real", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    PlanningImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documents = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LevelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plannings", x => x.PlanID);
                    table.ForeignKey(
                        name: "FK_Plannings_BudgetAmounts_BudgetAmountID",
                        column: x => x.BudgetAmountID,
                        principalTable: "BudgetAmounts",
                        principalColumn: "BudgetAmountID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plannings_CompanyNames_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "CompanyNames",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plannings_Expensess_ExpensesID",
                        column: x => x.ExpensesID,
                        principalTable: "Expensess",
                        principalColumn: "ExpensesID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plannings_Levelss_LevelID",
                        column: x => x.LevelID,
                        principalTable: "Levelss",
                        principalColumn: "LevelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plannings_VATs_VATID",
                        column: x => x.VATID,
                        principalTable: "VATs",
                        principalColumn: "VATID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plannings_WorkDoneTypes_WorkDoneTypeID",
                        column: x => x.WorkDoneTypeID,
                        principalTable: "WorkDoneTypes",
                        principalColumn: "WorkDoneTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Plannings_WorkDones_WorkDoneID",
                        column: x => x.WorkDoneID,
                        principalTable: "WorkDones",
                        principalColumn: "WorkDoneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubLevelss",
                columns: table => new
                {
                    SubLevelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevelID = table.Column<int>(type: "int", nullable: false),
                    SubLevelNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubLevelss", x => x.SubLevelID);
                    table.ForeignKey(
                        name: "FK_SubLevelss_Levelss_LevelID",
                        column: x => x.LevelID,
                        principalTable: "Levelss",
                        principalColumn: "LevelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Realizations",
                columns: table => new
                {
                    RealizationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkDoneID = table.Column<int>(type: "int", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: false),
                    PayStatus = table.Column<bool>(type: "bit", nullable: false),
                    UsableBudget = table.Column<float>(type: "real", nullable: false),
                    RemainingBudget = table.Column<float>(type: "real", nullable: false),
                    TotalExpenditure = table.Column<float>(type: "real", nullable: false),
                    BudgetTypeID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    LevelID = table.Column<int>(type: "int", nullable: false),
                    SubLevelID = table.Column<int>(type: "int", nullable: false),
                    VATID = table.Column<int>(type: "int", nullable: false),
                    ExcVAT = table.Column<int>(type: "int", nullable: false),
                    InVAT = table.Column<int>(type: "int", nullable: false),
                    CompanyID = table.Column<int>(type: "int", nullable: false),
                    WorkDoneTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realizations", x => x.RealizationID);
                    table.ForeignKey(
                        name: "FK_Realizations_AppControls_ID",
                        column: x => x.ID,
                        principalTable: "AppControls",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Realizations_Budgets_BudgetTypeID",
                        column: x => x.BudgetTypeID,
                        principalTable: "Budgets",
                        principalColumn: "BudgetTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Realizations_CompanyNames_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "CompanyNames",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Realizations_Levelss_LevelID",
                        column: x => x.LevelID,
                        principalTable: "Levelss",
                        principalColumn: "LevelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Realizations_SubLevelss_SubLevelID",
                        column: x => x.SubLevelID,
                        principalTable: "SubLevelss",
                        principalColumn: "SubLevelID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Realizations_VATs_VATID",
                        column: x => x.VATID,
                        principalTable: "VATs",
                        principalColumn: "VATID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Realizations_WorkDoneTypes_WorkDoneTypeID",
                        column: x => x.WorkDoneTypeID,
                        principalTable: "WorkDoneTypes",
                        principalColumn: "WorkDoneTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Realizations_WorkDones_WorkDoneID",
                        column: x => x.WorkDoneID,
                        principalTable: "WorkDones",
                        principalColumn: "WorkDoneID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddUsers_RoleID",
                table: "AddUsers",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_AppControls_ExpensesID",
                table: "AppControls",
                column: "ExpensesID");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_CompanyID",
                table: "Approvals",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_ExpensesID",
                table: "Approvals",
                column: "ExpensesID");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_LevelID",
                table: "Approvals",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_VATID",
                table: "Approvals",
                column: "VATID");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_WorkDoneID",
                table: "Approvals",
                column: "WorkDoneID");

            migrationBuilder.CreateIndex(
                name: "IX_Approvals_WorkDoneTypeID",
                table: "Approvals",
                column: "WorkDoneTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Expensess_BudgetTypeID",
                table: "Expensess",
                column: "BudgetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Levelss_ExpensesID",
                table: "Levelss",
                column: "ExpensesID");

            migrationBuilder.CreateIndex(
                name: "IX_Plannings_BudgetAmountID",
                table: "Plannings",
                column: "BudgetAmountID");

            migrationBuilder.CreateIndex(
                name: "IX_Plannings_CompanyID",
                table: "Plannings",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Plannings_ExpensesID",
                table: "Plannings",
                column: "ExpensesID");

            migrationBuilder.CreateIndex(
                name: "IX_Plannings_LevelID",
                table: "Plannings",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Plannings_VATID",
                table: "Plannings",
                column: "VATID");

            migrationBuilder.CreateIndex(
                name: "IX_Plannings_WorkDoneID",
                table: "Plannings",
                column: "WorkDoneID");

            migrationBuilder.CreateIndex(
                name: "IX_Plannings_WorkDoneTypeID",
                table: "Plannings",
                column: "WorkDoneTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Proxies_RoleID",
                table: "Proxies",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Realizations_BudgetTypeID",
                table: "Realizations",
                column: "BudgetTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Realizations_CompanyID",
                table: "Realizations",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Realizations_ID",
                table: "Realizations",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Realizations_LevelID",
                table: "Realizations",
                column: "LevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Realizations_SubLevelID",
                table: "Realizations",
                column: "SubLevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Realizations_VATID",
                table: "Realizations",
                column: "VATID");

            migrationBuilder.CreateIndex(
                name: "IX_Realizations_WorkDoneID",
                table: "Realizations",
                column: "WorkDoneID");

            migrationBuilder.CreateIndex(
                name: "IX_Realizations_WorkDoneTypeID",
                table: "Realizations",
                column: "WorkDoneTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Refuses_ExpensesID",
                table: "Refuses",
                column: "ExpensesID");

            migrationBuilder.CreateIndex(
                name: "IX_SubLevelss_LevelID",
                table: "SubLevelss",
                column: "LevelID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddUsers");

            migrationBuilder.DropTable(
                name: "Approvals");

            migrationBuilder.DropTable(
                name: "Plannings");

            migrationBuilder.DropTable(
                name: "Proxies");

            migrationBuilder.DropTable(
                name: "Realizations");

            migrationBuilder.DropTable(
                name: "Refuses");

            migrationBuilder.DropTable(
                name: "BudgetAmounts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "AppControls");

            migrationBuilder.DropTable(
                name: "CompanyNames");

            migrationBuilder.DropTable(
                name: "SubLevelss");

            migrationBuilder.DropTable(
                name: "VATs");

            migrationBuilder.DropTable(
                name: "WorkDoneTypes");

            migrationBuilder.DropTable(
                name: "WorkDones");

            migrationBuilder.DropTable(
                name: "Levelss");

            migrationBuilder.DropTable(
                name: "Expensess");

            migrationBuilder.DropTable(
                name: "Budgets");
        }
    }
}
