using Microsoft.EntityFrameworkCore.Migrations;

namespace CrazyBooking.DL.Migrations
{
    public partial class ChangesinBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_GuestDetails_GuestDetailId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Shows_ShowId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Shows_Booking_BookingDetailsId",
                table: "Shows");

            migrationBuilder.DropIndex(
                name: "IX_Shows_BookingDetailsId",
                table: "Shows");

            migrationBuilder.DropIndex(
                name: "IX_Booking_GuestDetailId",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "BookingDetailsId",
                table: "Shows");

            migrationBuilder.DropColumn(
                name: "GuestDetailId",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "ShowId",
                table: "Booking",
                newName: "ShowID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_ShowId",
                table: "Booking",
                newName: "IX_Booking_ShowID");

            migrationBuilder.AlterColumn<int>(
                name: "ShowID",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Shows_ShowID",
                table: "Booking",
                column: "ShowID",
                principalTable: "Shows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Shows_ShowID",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "ShowID",
                table: "Booking",
                newName: "ShowId");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_ShowID",
                table: "Booking",
                newName: "IX_Booking_ShowId");

            migrationBuilder.AddColumn<int>(
                name: "BookingDetailsId",
                table: "Shows",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ShowId",
                table: "Booking",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "GuestDetailId",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shows_BookingDetailsId",
                table: "Shows",
                column: "BookingDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_GuestDetailId",
                table: "Booking",
                column: "GuestDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_GuestDetails_GuestDetailId",
                table: "Booking",
                column: "GuestDetailId",
                principalTable: "GuestDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Shows_ShowId",
                table: "Booking",
                column: "ShowId",
                principalTable: "Shows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shows_Booking_BookingDetailsId",
                table: "Shows",
                column: "BookingDetailsId",
                principalTable: "Booking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
