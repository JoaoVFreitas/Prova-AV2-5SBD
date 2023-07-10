using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CooperativaCredito_AGrana.Migrations
{
    public partial class TesteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdComissaoVendedor",
                table: "Vendedores",
                newName: "ComissaoVendedorId");

            migrationBuilder.RenameColumn(
                name: "IdVendedor",
                table: "Financiamentos",
                newName: "VendedorId");

            migrationBuilder.RenameColumn(
                name: "IdAssociado",
                table: "Financiamentos",
                newName: "AssociadoId");

            migrationBuilder.RenameColumn(
                name: "IdComissaoEmpresa",
                table: "Empresas",
                newName: "ComissaoEmpresaId");

            migrationBuilder.RenameColumn(
                name: "IdVendedor",
                table: "ComissoesVendedor",
                newName: "VendedorId");

            migrationBuilder.RenameColumn(
                name: "IdFinanciamento",
                table: "ComissoesVendedor",
                newName: "FinanciamentoId");

            migrationBuilder.RenameColumn(
                name: "IdFinanciamento",
                table: "ComissoesEmpresa",
                newName: "FinanciamentoId");

            migrationBuilder.RenameColumn(
                name: "IdEmpresa",
                table: "ComissoesEmpresa",
                newName: "EmpresaId");

            migrationBuilder.RenameColumn(
                name: "IdFinanciamento",
                table: "Associados",
                newName: "FinanciamentoId");

            migrationBuilder.RenameColumn(
                name: "IdEmpresa",
                table: "Associados",
                newName: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_ComissaoVendedorId",
                table: "Vendedores",
                column: "ComissaoVendedorId",
                unique: true,
                filter: "[ComissaoVendedorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Financiamentos_AssociadoId",
                table: "Financiamentos",
                column: "AssociadoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Financiamentos_VendedorId",
                table: "Financiamentos",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_ComissaoEmpresaId",
                table: "Empresas",
                column: "ComissaoEmpresaId",
                unique: true,
                filter: "[ComissaoEmpresaId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ComissoesVendedor_FinanciamentoId",
                table: "ComissoesVendedor",
                column: "FinanciamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ComissoesVendedor_VendedorId",
                table: "ComissoesVendedor",
                column: "VendedorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComissoesEmpresa_EmpresaId",
                table: "ComissoesEmpresa",
                column: "EmpresaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComissoesEmpresa_FinanciamentoId",
                table: "ComissoesEmpresa",
                column: "FinanciamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Associados_EmpresaId",
                table: "Associados",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Associados_FinanciamentoId",
                table: "Associados",
                column: "FinanciamentoId",
                unique: true,
                filter: "[FinanciamentoId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Associados_Empresas_EmpresaId",
                table: "Associados",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Associados_Financiamentos_FinanciamentoId",
                table: "Associados",
                column: "FinanciamentoId",
                principalTable: "Financiamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ComissoesEmpresa_Empresas_EmpresaId",
                table: "ComissoesEmpresa",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComissoesEmpresa_Financiamentos_FinanciamentoId",
                table: "ComissoesEmpresa",
                column: "FinanciamentoId",
                principalTable: "Financiamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComissoesVendedor_Financiamentos_FinanciamentoId",
                table: "ComissoesVendedor",
                column: "FinanciamentoId",
                principalTable: "Financiamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComissoesVendedor_Vendedores_VendedorId",
                table: "ComissoesVendedor",
                column: "VendedorId",
                principalTable: "Vendedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empresas_ComissoesEmpresa_ComissaoEmpresaId",
                table: "Empresas",
                column: "ComissaoEmpresaId",
                principalTable: "ComissoesEmpresa",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Financiamentos_Associados_AssociadoId",
                table: "Financiamentos",
                column: "AssociadoId",
                principalTable: "Associados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Financiamentos_Vendedores_VendedorId",
                table: "Financiamentos",
                column: "VendedorId",
                principalTable: "Vendedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedores_ComissoesVendedor_ComissaoVendedorId",
                table: "Vendedores",
                column: "ComissaoVendedorId",
                principalTable: "ComissoesVendedor",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associados_Empresas_EmpresaId",
                table: "Associados");

            migrationBuilder.DropForeignKey(
                name: "FK_Associados_Financiamentos_FinanciamentoId",
                table: "Associados");

            migrationBuilder.DropForeignKey(
                name: "FK_ComissoesEmpresa_Empresas_EmpresaId",
                table: "ComissoesEmpresa");

            migrationBuilder.DropForeignKey(
                name: "FK_ComissoesEmpresa_Financiamentos_FinanciamentoId",
                table: "ComissoesEmpresa");

            migrationBuilder.DropForeignKey(
                name: "FK_ComissoesVendedor_Financiamentos_FinanciamentoId",
                table: "ComissoesVendedor");

            migrationBuilder.DropForeignKey(
                name: "FK_ComissoesVendedor_Vendedores_VendedorId",
                table: "ComissoesVendedor");

            migrationBuilder.DropForeignKey(
                name: "FK_Empresas_ComissoesEmpresa_ComissaoEmpresaId",
                table: "Empresas");

            migrationBuilder.DropForeignKey(
                name: "FK_Financiamentos_Associados_AssociadoId",
                table: "Financiamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Financiamentos_Vendedores_VendedorId",
                table: "Financiamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedores_ComissoesVendedor_ComissaoVendedorId",
                table: "Vendedores");

            migrationBuilder.DropIndex(
                name: "IX_Vendedores_ComissaoVendedorId",
                table: "Vendedores");

            migrationBuilder.DropIndex(
                name: "IX_Financiamentos_AssociadoId",
                table: "Financiamentos");

            migrationBuilder.DropIndex(
                name: "IX_Financiamentos_VendedorId",
                table: "Financiamentos");

            migrationBuilder.DropIndex(
                name: "IX_Empresas_ComissaoEmpresaId",
                table: "Empresas");

            migrationBuilder.DropIndex(
                name: "IX_ComissoesVendedor_FinanciamentoId",
                table: "ComissoesVendedor");

            migrationBuilder.DropIndex(
                name: "IX_ComissoesVendedor_VendedorId",
                table: "ComissoesVendedor");

            migrationBuilder.DropIndex(
                name: "IX_ComissoesEmpresa_EmpresaId",
                table: "ComissoesEmpresa");

            migrationBuilder.DropIndex(
                name: "IX_ComissoesEmpresa_FinanciamentoId",
                table: "ComissoesEmpresa");

            migrationBuilder.DropIndex(
                name: "IX_Associados_EmpresaId",
                table: "Associados");

            migrationBuilder.DropIndex(
                name: "IX_Associados_FinanciamentoId",
                table: "Associados");

            migrationBuilder.RenameColumn(
                name: "ComissaoVendedorId",
                table: "Vendedores",
                newName: "IdComissaoVendedor");

            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "Financiamentos",
                newName: "IdVendedor");

            migrationBuilder.RenameColumn(
                name: "AssociadoId",
                table: "Financiamentos",
                newName: "IdAssociado");

            migrationBuilder.RenameColumn(
                name: "ComissaoEmpresaId",
                table: "Empresas",
                newName: "IdComissaoEmpresa");

            migrationBuilder.RenameColumn(
                name: "VendedorId",
                table: "ComissoesVendedor",
                newName: "IdVendedor");

            migrationBuilder.RenameColumn(
                name: "FinanciamentoId",
                table: "ComissoesVendedor",
                newName: "IdFinanciamento");

            migrationBuilder.RenameColumn(
                name: "FinanciamentoId",
                table: "ComissoesEmpresa",
                newName: "IdFinanciamento");

            migrationBuilder.RenameColumn(
                name: "EmpresaId",
                table: "ComissoesEmpresa",
                newName: "IdEmpresa");

            migrationBuilder.RenameColumn(
                name: "FinanciamentoId",
                table: "Associados",
                newName: "IdFinanciamento");

            migrationBuilder.RenameColumn(
                name: "EmpresaId",
                table: "Associados",
                newName: "IdEmpresa");
        }
    }
}
