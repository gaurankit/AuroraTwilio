using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OrderPoolManager.Repositories.DBModels
{
    public partial class OrderContext : DbContext
    {
        public virtual DbSet<EnsureBookingJobMaxOrderId> EnsureBookingJobMaxOrderId { get; set; }
        public virtual DbSet<EnsureBookingJobPn> EnsureBookingJobPn { get; set; }
        public virtual DbSet<EnsureBookingJobTp> EnsureBookingJobTp { get; set; }
        public virtual DbSet<EnsureBookingJobTpn> EnsureBookingJobTpn { get; set; }
        public virtual DbSet<EnsureBookingJobTpn2> EnsureBookingJobTpn2 { get; set; }
        public virtual DbSet<EnsureBookingJobTpn3> EnsureBookingJobTpn3 { get; set; }
        public virtual DbSet<EnsureBookingJobTpn4> EnsureBookingJobTpn4 { get; set; }
        public virtual DbSet<EnsureBookingJobVcd> EnsureBookingJobVcd { get; set; }
        public virtual DbSet<TActivity> TActivity { get; set; }
        public virtual DbSet<TActivityAdditionalOptions> TActivityAdditionalOptions { get; set; }
        public virtual DbSet<TAdagentInformation> TAdagentInformation { get; set; }
        public virtual DbSet<TAirTicket> TAirTicket { get; set; }
        public virtual DbSet<TAirTicketAdditionalOptions> TAirTicketAdditionalOptions { get; set; }
        public virtual DbSet<TCarRental> TCarRental { get; set; }
        public virtual DbSet<TCarRentalAdditionalOptions> TCarRentalAdditionalOptions { get; set; }
        public virtual DbSet<TCategoryCancelCriteria> TCategoryCancelCriteria { get; set; }
        public virtual DbSet<TCategoryCancelDetail> TCategoryCancelDetail { get; set; }
        public virtual DbSet<TCategoryCancelDetailError> TCategoryCancelDetailError { get; set; }
        public virtual DbSet<TCategoryCancelDetailErrorType> TCategoryCancelDetailErrorType { get; set; }
        public virtual DbSet<TCategoryCancelDetailReasonType> TCategoryCancelDetailReasonType { get; set; }
        public virtual DbSet<TCategoryClientAccounting> TCategoryClientAccounting { get; set; }
        public virtual DbSet<TClassOfServiceType> TClassOfServiceType { get; set; }
        public virtual DbSet<TClassOfServiceTypeCulture> TClassOfServiceTypeCulture { get; set; }
        public virtual DbSet<TCnxsuperPnrForCruise> TCnxsuperPnrForCruise { get; set; }
        public virtual DbSet<TCreditReasonType> TCreditReasonType { get; set; }
        public virtual DbSet<TCruise> TCruise { get; set; }
        public virtual DbSet<TCruiseBookingPaymentState> TCruiseBookingPaymentState { get; set; }
        public virtual DbSet<TCruiseLine> TCruiseLine { get; set; }
        public virtual DbSet<TCruiseProcessingStatus> TCruiseProcessingStatus { get; set; }
        public virtual DbSet<TCruiseShip> TCruiseShip { get; set; }
        public virtual DbSet<TCruiseShipCulture> TCruiseShipCulture { get; set; }
        public virtual DbSet<TCurrencyType> TCurrencyType { get; set; }
        public virtual DbSet<TCustomCategoryField> TCustomCategoryField { get; set; }
        public virtual DbSet<TDatabaseDeployHistory> TDatabaseDeployHistory { get; set; }
        public virtual DbSet<TDirtyPnrinfo> TDirtyPnrinfo { get; set; }
        public virtual DbSet<TFeeDetail> TFeeDetail { get; set; }
        public virtual DbSet<THotelProperty> THotelProperty { get; set; }
        public virtual DbSet<THotelRoom> THotelRoom { get; set; }
        public virtual DbSet<THotelRoomAdditionalOptions> THotelRoomAdditionalOptions { get; set; }
        public virtual DbSet<TInsurance> TInsurance { get; set; }
        public virtual DbSet<TOrder> TOrder { get; set; }
        public virtual DbSet<TOrderAccounting> TOrderAccounting { get; set; }
        public virtual DbSet<TOrderAdjustment> TOrderAdjustment { get; set; }
        public virtual DbSet<TOrderAdjustmentError> TOrderAdjustmentError { get; set; }
        public virtual DbSet<TOrderAmountType> TOrderAmountType { get; set; }
        public virtual DbSet<TOrderCancelErrorType> TOrderCancelErrorType { get; set; }
        public virtual DbSet<TOrderCategoryCancel> TOrderCategoryCancel { get; set; }
        public virtual DbSet<TOrderCategoryCancelError> TOrderCategoryCancelError { get; set; }
        public virtual DbSet<TOrderCategoryCancelReason> TOrderCategoryCancelReason { get; set; }
        public virtual DbSet<TOrderCategoryKey> TOrderCategoryKey { get; set; }
        public virtual DbSet<TOrderCurrency> TOrderCurrency { get; set; }
        public virtual DbSet<TOrderDetail> TOrderDetail { get; set; }
        public virtual DbSet<TOrderDetailAmountType> TOrderDetailAmountType { get; set; }
        public virtual DbSet<TOrderDetailConversion> TOrderDetailConversion { get; set; }
        public virtual DbSet<TOrderDetailCurrency> TOrderDetailCurrency { get; set; }
        public virtual DbSet<TOrderDetailCurrencyStatus> TOrderDetailCurrencyStatus { get; set; }
        public virtual DbSet<TOrderDetailProviderLocator> TOrderDetailProviderLocator { get; set; }
        public virtual DbSet<TOrderDetailTripProduct> TOrderDetailTripProduct { get; set; }
        public virtual DbSet<TOrderError> TOrderError { get; set; }
        public virtual DbSet<TOrderNote> TOrderNote { get; set; }
        public virtual DbSet<TOrderNoteCategory> TOrderNoteCategory { get; set; }
        public virtual DbSet<TOrderParticipant> TOrderParticipant { get; set; }
        public virtual DbSet<TOrderParticipantTax> TOrderParticipantTax { get; set; }
        public virtual DbSet<TOrderProviderLocator> TOrderProviderLocator { get; set; }
        public virtual DbSet<TOrderRefundFailure> TOrderRefundFailure { get; set; }
        public virtual DbSet<TOrderRefundFailureDetail> TOrderRefundFailureDetail { get; set; }
        public virtual DbSet<TOrderStatusType> TOrderStatusType { get; set; }
        public virtual DbSet<TOrderStatusTypeCulture> TOrderStatusTypeCulture { get; set; }
        public virtual DbSet<TOrderTripFolder> TOrderTripFolder { get; set; }
        public virtual DbSet<TOrderType> TOrderType { get; set; }
        public virtual DbSet<TPackage> TPackage { get; set; }
        public virtual DbSet<TParticipantCustomClientField> TParticipantCustomClientField { get; set; }
        public virtual DbSet<TPrimaryCruiseDestination> TPrimaryCruiseDestination { get; set; }
        public virtual DbSet<TPromotions> TPromotions { get; set; }
        public virtual DbSet<TProvider> TProvider { get; set; }
        public virtual DbSet<TProviderCancelPolicy> TProviderCancelPolicy { get; set; }
        public virtual DbSet<TProviderCancelPolicyProviderCancelPolicyText> TProviderCancelPolicyProviderCancelPolicyText { get; set; }
        public virtual DbSet<TProviderCancelPolicyText> TProviderCancelPolicyText { get; set; }
        public virtual DbSet<TProviderCancelPolicyTextCulture> TProviderCancelPolicyTextCulture { get; set; }
        public virtual DbSet<TProviderCategory> TProviderCategory { get; set; }
        public virtual DbSet<TProviderCulture> TProviderCulture { get; set; }
        public virtual DbSet<TProviderLocator> TProviderLocator { get; set; }
        public virtual DbSet<TProviderLocatorType> TProviderLocatorType { get; set; }
        public virtual DbSet<TProviderType> TProviderType { get; set; }
        public virtual DbSet<TRetailProduct> TRetailProduct { get; set; }
        public virtual DbSet<TRuleGroupRegisterDetail> TRuleGroupRegisterDetail { get; set; }
        public virtual DbSet<TShipping> TShipping { get; set; }
        public virtual DbSet<TShippingStatusType> TShippingStatusType { get; set; }
        public virtual DbSet<TSingleUseCard> TSingleUseCard { get; set; }
        public virtual DbSet<ZQueueLog> ZQueueLog { get; set; }

        // Unable to generate entity type for table 'dbo.tProviderCancelPolicyCancelFee'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=QDORXeCXL16.loyaltytravelservices.com\CoreSQLORXeCXL,14332;Trusted_Connection=True;Database=qORDER");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnsureBookingJobMaxOrderId>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.OrderLocator).IsUnicode(false);
            });

            modelBuilder.Entity<EnsureBookingJobPn>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();
            });

            modelBuilder.Entity<EnsureBookingJobTp>(entity =>
            {
                entity.HasKey(e => new { e.ConfirmationNumber, e.TripProductId });

                entity.Property(e => e.ConfirmationNumber).IsUnicode(false);

                entity.Property(e => e.CityCode).IsUnicode(false);
            });

            modelBuilder.Entity<EnsureBookingJobTpn>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.TravelPlanName).IsUnicode(false);
            });

            modelBuilder.Entity<EnsureBookingJobTpn2>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();
            });

            modelBuilder.Entity<EnsureBookingJobTpn3>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.TravelPlanName).IsUnicode(false);
            });

            modelBuilder.Entity<EnsureBookingJobTpn4>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();
            });

            modelBuilder.Entity<EnsureBookingJobVcd>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TActivity>(entity =>
            {
                entity.HasIndex(e => e.ActivityUid)
                    .HasName("tActivityUID_UDX")
                    .IsUnique();

                entity.HasIndex(e => e.CreditReasonTypeId);

                entity.HasIndex(e => e.OrderStatusTypeId);

                entity.HasIndex(e => new { e.ActivityId, e.OrderDetailId, e.ActivityFirstName })
                    .HasName("IX_Activity_ActivityFirstName");

                entity.HasIndex(e => new { e.OrderDetailId, e.ActivityId, e.ActivityUid })
                    .HasName("IXC_tACTIVITY")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.OrderDetailId, e.OrderStatusTypeId, e.ActivityStartDate })
                    .HasName("IX_tActivity_OrderStatusTypeID_ActivityStartDate_OrderDetailID");

                entity.HasIndex(e => new { e.OrderDetailId, e.OrderStatusTypeId, e.CreditReasonTypeId })
                    .HasName("tActivityIDs_NDX");

                entity.Property(e => e.ActivityClientCatalogCode).IsUnicode(false);

                entity.Property(e => e.ActivityConfirmationCode).IsUnicode(false);

                entity.Property(e => e.ActivityCountry).IsUnicode(false);

                entity.Property(e => e.ActivityCurrencyDescription).IsUnicode(false);

                entity.Property(e => e.ActivityLastUpdatedBy).IsUnicode(false);

                entity.Property(e => e.CreditReasonTypeId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CreditReasonType)
                    .WithMany(p => p.TActivity)
                    .HasForeignKey(d => d.CreditReasonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCreditReasonType_tActivity_FK");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TActivity)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tActivity_FK");

                entity.HasOne(d => d.OrderStatusType)
                    .WithMany(p => p.TActivity)
                    .HasForeignKey(d => d.OrderStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderStatusType_tActivity_FK");
            });

            modelBuilder.Entity<TActivityAdditionalOptions>(entity =>
            {
                entity.HasIndex(e => e.ActivityAdditionalOptionsId)
                    .HasName("UIX_ActivityAdditionalOptions")
                    .IsUnique();

                entity.Property(e => e.ActivityId).ValueGeneratedNever();

                entity.Property(e => e.ActivityAdditionalOptionsId).ValueGeneratedOnAdd();

                entity.Property(e => e.FareQuoteAdjustmentType).IsUnicode(false);

                entity.HasOne(d => d.Activity)
                    .WithOne(p => p.TActivityAdditionalOptions)
                    .HasForeignKey<TActivityAdditionalOptions>(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tActivityAdditionalOptions_tActivity");
            });

            modelBuilder.Entity<TAdagentInformation>(entity =>
            {
                entity.HasIndex(e => e.OrderCreatedBy)
                    .HasName("NCI_tADAgentInformation_OrderCreatedBy")
                    .IsUnique();
            });

            modelBuilder.Entity<TAirTicket>(entity =>
            {
                entity.HasIndex(e => e.AirTicketUid)
                    .HasName("tAirTicket_IXUN_AirTicketUID")
                    .IsUnique();

                entity.HasIndex(e => e.ClassOfServiceTypeId);

                entity.HasIndex(e => e.CreditReasonTypeId);

                entity.HasIndex(e => e.OrderDetailId);

                entity.HasIndex(e => new { e.AirTicketId, e.OrderDetailId, e.AirTicketFirstName })
                    .HasName("IX_AirTicket_AirTicketFirstName");

                entity.HasIndex(e => new { e.OrderDetailId, e.OrderStatusTypeId, e.AirTicketId })
                    .HasName("tAirTicket_IXUC_OrderDetailId")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.AirTicketCurrencyDescription, e.OrderDetailId, e.AirTicketId, e.AirTicketUid })
                    .HasName("NCI_tAirTicket_OrderDetailID_ID_UID");

                entity.HasIndex(e => new { e.AirTicketDepartureDateTime, e.AirTicketReturnDateTime, e.AirTicketFareQuote, e.AirTicketId, e.AirTicketUid, e.OrderDetailId, e.OrderStatusTypeId })
                    .HasName("tAirTicket_IXNN_OrderStatusTypeID");

                entity.Property(e => e.AirTicketClientCatalogCode).IsUnicode(false);

                entity.Property(e => e.AirTicketConfirmationCode).IsUnicode(false);

                entity.Property(e => e.AirTicketCurrencyDescription).IsUnicode(false);

                entity.Property(e => e.AirTicketDestination).IsUnicode(false);

                entity.Property(e => e.AirTicketLastUpdatedBy).IsUnicode(false);

                entity.Property(e => e.AirTicketOrigin).IsUnicode(false);

                entity.Property(e => e.AirlineCode).HasDefaultValueSql("('')");

                entity.Property(e => e.CreditReasonTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Iata).IsUnicode(false);

                entity.Property(e => e.PseudoCityCode).IsUnicode(false);

                entity.HasOne(d => d.ClassOfServiceType)
                    .WithMany(p => p.TAirTicket)
                    .HasForeignKey(d => d.ClassOfServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tClassOfServiceType_tAirTicket_FK");

                entity.HasOne(d => d.CreditReasonType)
                    .WithMany(p => p.TAirTicket)
                    .HasForeignKey(d => d.CreditReasonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCreditReasonType_tAirTicket_FK");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TAirTicket)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tAirTicket_FK");

                entity.HasOne(d => d.OrderStatusType)
                    .WithMany(p => p.TAirTicket)
                    .HasForeignKey(d => d.OrderStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderStatusType_tAirTicket_FK");
            });

            modelBuilder.Entity<TAirTicketAdditionalOptions>(entity =>
            {
                entity.HasIndex(e => e.AirTicketAdditionalOptionsId)
                    .HasName("UIX_AirTicketAdditionalOptions")
                    .IsUnique();

                entity.Property(e => e.AirTicketId).ValueGeneratedNever();

                entity.Property(e => e.AirTicketAdditionalOptionsId).ValueGeneratedOnAdd();

                entity.Property(e => e.FareQuoteAdjustmentType).IsUnicode(false);

                entity.HasOne(d => d.AirTicket)
                    .WithOne(p => p.TAirTicketAdditionalOptions)
                    .HasForeignKey<TAirTicketAdditionalOptions>(d => d.AirTicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tAirTicketAdditionalOptions_tAirTicket");
            });

            modelBuilder.Entity<TCarRental>(entity =>
            {
                entity.HasIndex(e => e.CarRentalUid)
                    .HasName("tCarRentalUID_UDX")
                    .IsUnique();

                entity.HasIndex(e => e.CreditReasonTypeId);

                entity.HasIndex(e => e.OrderDetailId);

                entity.HasIndex(e => e.OrderStatusTypeId);

                entity.HasIndex(e => new { e.CarRentalId, e.OrderDetailId, e.CarRentalFirstName })
                    .HasName("IX_tCarRental_CarRentalFirstName");

                entity.HasIndex(e => new { e.CarRentalCurrencyDescription, e.OrderDetailId, e.CarRentalId, e.CarRentalUid })
                    .HasName("NCI_tCarRental_OrderDetailID_ID_UID");

                entity.HasIndex(e => new { e.OrderDetailId, e.OrderStatusTypeId, e.CreditReasonTypeId, e.CarRentalId })
                    .HasName("tCarRental_IXUC_OrderDetailID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.CarRentalId, e.CarRentalUid, e.OrderDetailId, e.OrderStatusTypeId, e.CarRentalPickUpDateTime })
                    .HasName("IX_tCarRental_OrderStatusTypeID_CarRentalPickupDateTime_OrderDetailID");

                entity.Property(e => e.CarRentalCityDropOffLocation).IsUnicode(false);

                entity.Property(e => e.CarRentalCityPickUpLocation).IsUnicode(false);

                entity.Property(e => e.CarRentalClientCatalogCode).IsUnicode(false);

                entity.Property(e => e.CarRentalConfirmationCode).IsUnicode(false);

                entity.Property(e => e.CarRentalCurrencyDescription).IsUnicode(false);

                entity.Property(e => e.CarRentalDropOffLocation).IsUnicode(false);

                entity.Property(e => e.CarRentalLastUpdatedBy).IsUnicode(false);

                entity.Property(e => e.CarRentalPickUpLocation).IsUnicode(false);

                entity.Property(e => e.CarRentalType).IsUnicode(false);

                entity.Property(e => e.CreditReasonTypeId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.CreditReasonType)
                    .WithMany(p => p.TCarRental)
                    .HasForeignKey(d => d.CreditReasonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCreditReasonType_tCarRental_FK");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TCarRental)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tCarRental_FK");

                entity.HasOne(d => d.OrderStatusType)
                    .WithMany(p => p.TCarRental)
                    .HasForeignKey(d => d.OrderStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderStatusType_tCarRental_FK");
            });

            modelBuilder.Entity<TCarRentalAdditionalOptions>(entity =>
            {
                entity.HasIndex(e => e.CarRentalAdditionalOptionsId)
                    .HasName("UIX_CarRentalAdditionalOptions")
                    .IsUnique();

                entity.Property(e => e.CarRentalId).ValueGeneratedNever();

                entity.Property(e => e.CarRentalAdditionalOptionsId).ValueGeneratedOnAdd();

                entity.Property(e => e.FareQuoteAdjustmentType).IsUnicode(false);

                entity.HasOne(d => d.CarRental)
                    .WithOne(p => p.TCarRentalAdditionalOptions)
                    .HasForeignKey<TCarRentalAdditionalOptions>(d => d.CarRentalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tCarRentalAdditionalOptions_tCarRental");
            });

            modelBuilder.Entity<TCategoryCancelCriteria>(entity =>
            {
                entity.HasIndex(e => e.OrderCategoryKeyId);

                entity.Property(e => e.CancelFeeForeignCurrency).HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.OrderCategoryKey)
                    .WithMany(p => p.TCategoryCancelCriteria)
                    .HasForeignKey(d => d.OrderCategoryKeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCategoryCancelCriteria_tOrderCategoryKey_FK");
            });

            modelBuilder.Entity<TCategoryCancelDetail>(entity =>
            {
                entity.HasIndex(e => e.CategoryCancelDetailReasonTypeId)
                    .HasName("IX_tCategoryCancelDetail_CategoryCancelDetaillReasonID");

                entity.HasIndex(e => e.OrderCategoryKeyId);

                entity.HasIndex(e => e.ProviderId);

                entity.Property(e => e.ConfirmationCode).IsUnicode(false);

                entity.Property(e => e.ProviderCancelCode).IsUnicode(false);

                entity.HasOne(d => d.CategoryCancelDetailReasonType)
                    .WithMany(p => p.TCategoryCancelDetail)
                    .HasForeignKey(d => d.CategoryCancelDetailReasonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCategoryCancelDetailReason_tCategoryCancelDetail_FK");

                entity.HasOne(d => d.OrderCategoryKey)
                    .WithMany(p => p.TCategoryCancelDetail)
                    .HasForeignKey(d => d.OrderCategoryKeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderCategoryKey_tCategoryCancelDetail_FK");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TCategoryCancelDetail)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("tProvider_tCategoryCancelDetail_FK");
            });

            modelBuilder.Entity<TCategoryCancelDetailError>(entity =>
            {
                entity.HasIndex(e => e.CategoryCancelDetailErrorTypeId)
                    .HasName("IX_tCategoryCancelDetailError_OrderCancelErrorTypeID");

                entity.HasIndex(e => e.CategoryCancelDetailId)
                    .HasName("IX_tCategoryCancelDetailError_OrderCategoryCancelID");

                entity.HasOne(d => d.CategoryCancelDetailErrorType)
                    .WithMany(p => p.TCategoryCancelDetailError)
                    .HasForeignKey(d => d.CategoryCancelDetailErrorTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCategoryCancelDetailErrorType_tCategoryCancelDetailError_FK");

                entity.HasOne(d => d.CategoryCancelDetail)
                    .WithMany(p => p.TCategoryCancelDetailError)
                    .HasForeignKey(d => d.CategoryCancelDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCategoryCancelDetail_tCategoryCancelDetailError_FK");
            });

            modelBuilder.Entity<TCategoryCancelDetailErrorType>(entity =>
            {
                entity.Property(e => e.CategoryCancelDetailErrorType).IsUnicode(false);
            });

            modelBuilder.Entity<TCategoryCancelDetailReasonType>(entity =>
            {
                entity.Property(e => e.CategoryCancelDetailReasonTypeId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TCategoryClientAccounting>(entity =>
            {
                entity.HasIndex(e => e.CategoryUid)
                    .HasName("IXNC_tCategoryClientAccounting_CategoryUID");
            });

            modelBuilder.Entity<TClassOfServiceType>(entity =>
            {
                entity.Property(e => e.ClassOfServiceType).IsUnicode(false);

                entity.Property(e => e.OrderingToolClassOfServiceType).IsUnicode(false);
            });

            modelBuilder.Entity<TClassOfServiceTypeCulture>(entity =>
            {
                entity.HasIndex(e => e.ClassOfServiceTypeId);

                entity.HasOne(d => d.ClassOfServiceType)
                    .WithMany(p => p.TClassOfServiceTypeCulture)
                    .HasForeignKey(d => d.ClassOfServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tClassOfServiceType_tClassOfServiceTypeCulture_FK");
            });

            modelBuilder.Entity<TCreditReasonType>(entity =>
            {
                entity.Property(e => e.CreditReasonType).IsUnicode(false);
            });

            modelBuilder.Entity<TCruise>(entity =>
            {
                entity.HasIndex(e => e.CreditReasonTypeId);

                entity.HasIndex(e => e.CruiseShipId);

                entity.HasIndex(e => e.CruiseUid);

                entity.HasIndex(e => e.OrderStatusTypeId);

                entity.HasIndex(e => new { e.OrderDetailId, e.CruiseId })
                    .HasName("IXC_tCruise_NDX1")
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.CruiseId, e.OrderDetailId, e.CruiseFirstName })
                    .HasName("IX_Cruise_CruiseFirstName");

                entity.HasIndex(e => new { e.OrderDetailId, e.OrderStatusTypeId, e.CreditReasonTypeId })
                    .HasName("tCruiseIDs_NDX");

                entity.Property(e => e.ArrivalPortId).IsUnicode(false);

                entity.Property(e => e.ArrivalPortName).IsUnicode(false);

                entity.Property(e => e.CabinCategoryCode).IsUnicode(false);

                entity.Property(e => e.CabinCategoryName).IsUnicode(false);

                entity.Property(e => e.CabinNumber).IsUnicode(false);

                entity.Property(e => e.CabinTypeCode).IsUnicode(false);

                entity.Property(e => e.CreditReasonTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CruiseAge).IsUnicode(false);

                entity.Property(e => e.CruiseClientCatalogCode).IsUnicode(false);

                entity.Property(e => e.CruiseConfirmationCode).IsUnicode(false);

                entity.Property(e => e.CruiseCurrencyDescription).IsUnicode(false);

                entity.Property(e => e.CruiseGender).IsUnicode(false);

                entity.Property(e => e.CruiseLastUpdatedBy).IsUnicode(false);

                entity.Property(e => e.CruiseLoyaltyNumber).IsUnicode(false);

                entity.Property(e => e.CruiseSupplierName).IsUnicode(false);

                entity.Property(e => e.DeparturePortId).IsUnicode(false);

                entity.Property(e => e.DeparturePortName).IsUnicode(false);

                entity.Property(e => e.ExternalTripId).IsUnicode(false);

                entity.Property(e => e.GroupBookingId).IsUnicode(false);

                entity.Property(e => e.RateOptionCode).IsUnicode(false);

                entity.Property(e => e.RateType).IsUnicode(false);

                entity.HasOne(d => d.CreditReasonType)
                    .WithMany(p => p.TCruise)
                    .HasForeignKey(d => d.CreditReasonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCreditReasonType_tCruise_FK");

                entity.HasOne(d => d.CruiseBookingPaymentState)
                    .WithMany(p => p.TCruise)
                    .HasForeignKey(d => d.CruiseBookingPaymentStateId)
                    .HasConstraintName("tCruiseBookingPaymentState_tCruise_FK");

                entity.HasOne(d => d.CruiseProcessingStatus)
                    .WithMany(p => p.TCruise)
                    .HasForeignKey(d => d.CruiseProcessingStatusId)
                    .HasConstraintName("tCruiseProcessingStatus_tCruise_FK");

                entity.HasOne(d => d.CruiseShip)
                    .WithMany(p => p.TCruise)
                    .HasForeignKey(d => d.CruiseShipId)
                    .HasConstraintName("tCruiseShip_tCruise_FK");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TCruise)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tCruise_FK");

                entity.HasOne(d => d.OrderStatusType)
                    .WithMany(p => p.TCruise)
                    .HasForeignKey(d => d.OrderStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderStatusType_tCruise_FK");

                entity.HasOne(d => d.PrimaryCruiseDestination)
                    .WithMany(p => p.TCruise)
                    .HasForeignKey(d => d.PrimaryCruiseDestinationId)
                    .HasConstraintName("tPrimaryCruiseDestination_tCruise_FK");
            });

            modelBuilder.Entity<TCruiseBookingPaymentState>(entity =>
            {
                entity.Property(e => e.CruiseBookingPaymentState).IsUnicode(false);
            });

            modelBuilder.Entity<TCruiseLine>(entity =>
            {
                entity.Property(e => e.CruiseLineSupplierId).IsUnicode(false);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TCruiseLine)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("tCruiseLine_tProvider_FK");
            });

            modelBuilder.Entity<TCruiseProcessingStatus>(entity =>
            {
                entity.Property(e => e.CruiseProcessingStatus).IsUnicode(false);
            });

            modelBuilder.Entity<TCruiseShip>(entity =>
            {
                entity.Property(e => e.CruiseShipName).IsUnicode(false);

                entity.Property(e => e.SupplerShipId).IsUnicode(false);

                entity.HasOne(d => d.CruiseLine)
                    .WithMany(p => p.TCruiseShip)
                    .HasForeignKey(d => d.CruiseLineId)
                    .HasConstraintName("tCruiseShip_tCruiseLine_FK");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TCruiseShip)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("tCruiseShip_tProvider_FK");
            });

            modelBuilder.Entity<TCruiseShipCulture>(entity =>
            {
                entity.HasIndex(e => e.CruiseShipId);

                entity.Property(e => e.CruiseShipCultureName).IsUnicode(false);

                entity.HasOne(d => d.CruiseShip)
                    .WithMany(p => p.TCruiseShipCulture)
                    .HasForeignKey(d => d.CruiseShipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCruiseShip_tCruiseShipNameCulture_FK");
            });

            modelBuilder.Entity<TCurrencyType>(entity =>
            {
                entity.Property(e => e.CurrencyTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.CurrencyType).IsUnicode(false);

                entity.Property(e => e.CurrencyTypeDescription).IsUnicode(false);
            });

            modelBuilder.Entity<TCustomCategoryField>(entity =>
            {
                entity.HasIndex(e => new { e.CategoryFieldValue, e.ActivityId, e.CategoryFieldName })
                    .HasName("IX_tCustomCategoryField_ActivityID")
                    .HasFilter("([ActivityID] IS NOT NULL)");

                entity.HasIndex(e => new { e.CategoryFieldValue, e.AirTicketId, e.CategoryFieldName })
                    .HasName("IX_tCustomCategoryField_AirTicketID")
                    .HasFilter("([AirTicketID] IS NOT NULL)");

                entity.HasIndex(e => new { e.CategoryFieldValue, e.CarRentalId, e.CategoryFieldName })
                    .HasName("IX_tCustomCategoryField_CarRentalID")
                    .HasFilter("([CarRentalID] IS NOT NULL)");

                entity.HasIndex(e => new { e.CategoryFieldValue, e.CruiseId, e.CategoryFieldName })
                    .HasName("IX_tCustomCategoryField_CruiseID")
                    .HasFilter("([CruiseID] IS NOT NULL)");

                entity.HasIndex(e => new { e.CategoryFieldValue, e.HotelRoomId, e.CategoryFieldName })
                    .HasName("IX_tCustomCategoryField_HotelRoomID")
                    .HasFilter("([HotelRoomID] IS NOT NULL)");

                entity.HasIndex(e => new { e.CategoryFieldValue, e.PackageId, e.CategoryFieldName })
                    .HasName("IX_tCustomCategoryField_PackageID")
                    .HasFilter("([PackageID] IS NOT NULL)");

                entity.HasIndex(e => new { e.CategoryFieldValue, e.RetailProductId, e.CategoryFieldName })
                    .HasName("IX_tCustomCategoryField_RetailProductID")
                    .HasFilter("([RetailProductID] IS NOT NULL)");

                entity.Property(e => e.CategoryFieldName).IsUnicode(false);

                entity.Property(e => e.CategoryFieldValue).IsUnicode(false);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TCustomCategoryField)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tCustomCategoryField_tActivity");

                entity.HasOne(d => d.AirTicket)
                    .WithMany(p => p.TCustomCategoryField)
                    .HasForeignKey(d => d.AirTicketId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tCustomCategoryField_tAirTicket");

                entity.HasOne(d => d.CarRental)
                    .WithMany(p => p.TCustomCategoryField)
                    .HasForeignKey(d => d.CarRentalId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tCustomCategoryField_tCarRental");

                entity.HasOne(d => d.Cruise)
                    .WithMany(p => p.TCustomCategoryField)
                    .HasForeignKey(d => d.CruiseId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tCustomCategoryField_tCruise");

                entity.HasOne(d => d.HotelRoom)
                    .WithMany(p => p.TCustomCategoryField)
                    .HasForeignKey(d => d.HotelRoomId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tCustomCategoryField_tHotelRoom");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.TCustomCategoryField)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tCustomCategoryField_tPackage");

                entity.HasOne(d => d.RetailProduct)
                    .WithMany(p => p.TCustomCategoryField)
                    .HasForeignKey(d => d.RetailProductId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tCustomCategoryField_tRetailProduct");
            });

            modelBuilder.Entity<TDatabaseDeployHistory>(entity =>
            {
                entity.Property(e => e.DateTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TDirtyPnrinfo>(entity =>
            {
                entity.HasIndex(e => new { e.IsProcessed, e.CreateDate })
                    .HasName("NDX_tDirtyPNRInfo_IsProcessedCreateDateDesc");

                entity.HasIndex(e => new { e.IsProcessed, e.ProcessedDate })
                    .HasName("NDX_tDirtyPNRInfo_IsProcessedProcessDateDesc");

                entity.Property(e => e.Airline).IsUnicode(false);

                entity.Property(e => e.AirlinePhoneNumber).IsUnicode(false);

                entity.Property(e => e.Canumber).IsUnicode(false);

                entity.Property(e => e.ClientName).IsUnicode(false);

                entity.Property(e => e.EmailStatus).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.PhoneNumber).IsUnicode(false);

                entity.Property(e => e.ProgramScphoneNumber).IsUnicode(false);

                entity.Property(e => e.SuperPnr).IsUnicode(false);

                entity.Property(e => e.Template).IsUnicode(false);
            });

            modelBuilder.Entity<TFeeDetail>(entity =>
            {
                entity.HasIndex(e => e.ActivityId)
                    .HasName("IX_tFeeDetail_Activity_ID");

                entity.HasIndex(e => e.AirTicketId);

                entity.HasIndex(e => e.CarRentalId);

                entity.HasIndex(e => e.CruiseId);

                entity.HasIndex(e => e.HotelRoomId);

                entity.HasIndex(e => e.PackageId);

                entity.HasIndex(e => e.RetailProductId);

                entity.HasIndex(e => new { e.FeeDetailAmount, e.FeeDetailCategoryUid, e.CurrencyTypeId })
                    .HasName("tFeeDetail_IXNN_CurrencyTypeID");

                entity.HasIndex(e => new { e.FeeTypeId, e.CurrencyTypeId, e.FeeDetailAmount, e.FeeDetailAmountForeignCurrency, e.FeeDetailCategoryUid, e.FeeDetailId })
                    .HasName("tFeeDetail_IXNN_CategoryUID");

                entity.HasIndex(e => new { e.ActivityId, e.AirTicketId, e.CarRentalId, e.CruiseId, e.HotelRoomId, e.RetailProductId, e.PackageId })
                    .HasName("tFeeDetailIDs_NDX");

                entity.Property(e => e.ActivityId).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirTicketId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CarRentalId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CruiseId).HasDefaultValueSql("((0))");

                entity.Property(e => e.FeeDetailAmountForeignCurrency).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.HotelRoomId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageId).HasDefaultValueSql("((0))");

                entity.Property(e => e.RetailProductId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TFeeDetail)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tActivity_tFeeDetail_FK");

                entity.HasOne(d => d.AirTicket)
                    .WithMany(p => p.TFeeDetail)
                    .HasForeignKey(d => d.AirTicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tAirTicket_tFeeDetail_FK");

                entity.HasOne(d => d.CarRental)
                    .WithMany(p => p.TFeeDetail)
                    .HasForeignKey(d => d.CarRentalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCarRental_tFeeDetail_FK");

                entity.HasOne(d => d.Cruise)
                    .WithMany(p => p.TFeeDetail)
                    .HasForeignKey(d => d.CruiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCruise_tFeeDetail_FK");

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.TFeeDetail)
                    .HasForeignKey(d => d.CurrencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCurrencyType_tFeeDetail_FK");

                entity.HasOne(d => d.HotelRoom)
                    .WithMany(p => p.TFeeDetail)
                    .HasForeignKey(d => d.HotelRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tHotelRoom_tFeeDetail_FK");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.TFeeDetail)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tPackage_tFeeDetail_FK");

                entity.HasOne(d => d.RetailProduct)
                    .WithMany(p => p.TFeeDetail)
                    .HasForeignKey(d => d.RetailProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tRetailProduct_tFeeDetail_FK");
            });

            modelBuilder.Entity<THotelProperty>(entity =>
            {
                entity.Property(e => e.HotelPropertyPhone).IsUnicode(false);

                entity.Property(e => e.HotelPropertyPostalCode).IsUnicode(false);

                entity.Property(e => e.HotelPropertyState).IsUnicode(false);

                entity.Property(e => e.HotelPropertySupplierChainCode).IsUnicode(false);

                entity.Property(e => e.HotelPropertyVendorName).IsUnicode(false);
            });

            modelBuilder.Entity<THotelRoom>(entity =>
            {
                entity.HasIndex(e => e.CreditReasonTypeId);

                entity.HasIndex(e => e.HotelPropertyId);

                entity.HasIndex(e => e.HotelRoomUid)
                    .HasName("tHotelRoom_IXUN_HotelRoomUID")
                    .IsUnique();

                entity.HasIndex(e => e.OrderDetailId);

                entity.HasIndex(e => e.OrderStatusTypeId);

                entity.HasIndex(e => new { e.HotelRoomId, e.OrderDetailId, e.HotelRoomFirstName })
                    .HasName("IX_tHotelRoom_HotelRoomFirstName");

                entity.HasIndex(e => new { e.OrderDetailId, e.OrderStatusTypeId, e.HotelRoomCheckInDateTime })
                    .HasName("IX_HotelRoom_OrderStatusTypeID_HotelRoomCheckInDateTime_OrderDetailID");

                entity.HasIndex(e => new { e.OrderDetailId, e.OrderStatusTypeId, e.HotelRoomId })
                    .HasName("tHotelRoom_IXUC_OrderDetailID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.HotelRoomCurrencyDescription, e.OrderDetailId, e.HotelRoomId, e.HotelRoomUid })
                    .HasName("NCI_tHotelRoom_OrderDetailID_ID_UID");

                entity.Property(e => e.CreditReasonTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.HotelPropertyId).HasDefaultValueSql("((0))");

                entity.Property(e => e.HotelRoomClientCatalogCode).IsUnicode(false);

                entity.Property(e => e.HotelRoomConfirmationCode).IsUnicode(false);

                entity.Property(e => e.HotelRoomCurrencyDescription).IsUnicode(false);

                entity.Property(e => e.HotelRoomLastUpdatedBy).IsUnicode(false);

                entity.Property(e => e.HotelRoomLocation).IsUnicode(false);

                entity.HasOne(d => d.CreditReasonType)
                    .WithMany(p => p.THotelRoom)
                    .HasForeignKey(d => d.CreditReasonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCreditReasonType_tHotelRoom_FK");

                entity.HasOne(d => d.HotelProperty)
                    .WithMany(p => p.THotelRoom)
                    .HasForeignKey(d => d.HotelPropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tHotelProperty_tHotelRoom_FK");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.THotelRoom)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tHotelRoom_FK");

                entity.HasOne(d => d.OrderStatusType)
                    .WithMany(p => p.THotelRoom)
                    .HasForeignKey(d => d.OrderStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderStatusType_tHotelRoom_FK");
            });

            modelBuilder.Entity<THotelRoomAdditionalOptions>(entity =>
            {
                entity.HasIndex(e => e.HotelRoomAdditionalOptionsId)
                    .HasName("UIX_HotelRoomAdditionalOptions")
                    .IsUnique();

                entity.Property(e => e.HotelRoomId).ValueGeneratedNever();

                entity.Property(e => e.FareQuoteAdjustmentType).IsUnicode(false);

                entity.Property(e => e.HotelRoomAdditionalOptionsId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.HotelRoom)
                    .WithOne(p => p.THotelRoomAdditionalOptions)
                    .HasForeignKey<THotelRoomAdditionalOptions>(d => d.HotelRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tHotelRoomAdditionalOptions_tHotelRoom");
            });

            modelBuilder.Entity<TInsurance>(entity =>
            {
                entity.HasIndex(e => e.CreditReasonTypeId);

                entity.HasIndex(e => e.InsuranceConfirmationCode);

                entity.HasIndex(e => e.OrderDetailId);

                entity.HasIndex(e => e.OrderStatusTypeId);

                entity.HasIndex(e => e.ProviderId);

                entity.HasIndex(e => new { e.OrderDetailId, e.InsuranceId })
                    .HasName("IXC_tInsurance_OrderDetailID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.InsuranceConfirmationCode).IsUnicode(false);

                entity.Property(e => e.InsurancePolicyAmountForeignCurrency).HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.CreditReasonType)
                    .WithMany(p => p.TInsurance)
                    .HasForeignKey(d => d.CreditReasonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCreditReasonType_tInsurance_FK");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TInsurance)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tInsurance_FK");

                entity.HasOne(d => d.OrderStatusType)
                    .WithMany(p => p.TInsurance)
                    .HasForeignKey(d => d.OrderStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderStatusType_tInsurance_FK");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TInsurance)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProvider_tInsurance_FK");
            });

            modelBuilder.Entity<TOrder>(entity =>
            {
                entity.HasIndex(e => e.OrderClientId);

                entity.HasIndex(e => e.OrderCreateDateTime)
                    .HasName("tOrder_IXNN_OrderCreateDateTime");

                entity.HasIndex(e => e.OrderImportId)
                    .HasName("tOrder_OrderImportID_NDX");

                entity.HasIndex(e => new { e.OrderId, e.OrderClientId, e.OrderCreateDateTime })
                    .HasName("tOrder_IX_OrderClientID_OrderCreateDateTime");

                entity.Property(e => e.ClientOrderCode).IsUnicode(false);

                entity.Property(e => e.Lcid).HasDefaultValueSql("((1033))");

                entity.Property(e => e.OrderCreateDateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderCreatedBy).IsUnicode(false);

                entity.Property(e => e.OrderInvoiceNumber).IsUnicode(false);

                entity.Property(e => e.OrderProgramCurrencyCostFactor).HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderUpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<TOrderAccounting>(entity =>
            {
                entity.HasIndex(e => e.AccountingPaymentHeaderId)
                    .HasName("tOrderAccounting_IXNN_AcctPayHeaderID");

                entity.HasIndex(e => new { e.AccountingBranch, e.OrderId, e.AccountingProgramCode })
                    .HasName("tOrderAccount_IXNN_AccountingProgramCode");

                entity.HasIndex(e => new { e.OrderId, e.OrderAccountingId, e.AccountingPaymentHeaderId })
                    .HasName("tOrderAccounting_NDX1");

                entity.HasIndex(e => new { e.OrderAccountingId, e.OrderId, e.AccountingProgramCode, e.AccountingBranch, e.AccountingPaymentHeaderId, e.AccountingReportDate })
                    .HasName("tOrderAccounting_IXNN_AccountingReportDate");

                entity.Property(e => e.AccountingProgramCode).IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TOrderAccounting)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrder_tOrderAccounting_FK");
            });

            modelBuilder.Entity<TOrderAdjustment>(entity =>
            {
                entity.HasIndex(e => e.CreditReasonTypeId);

                entity.HasIndex(e => e.CurrencyTypeId);

                entity.HasIndex(e => e.OrderId)
                    .HasName("tOrderAdjustment_OrderID_NDX");

                entity.HasIndex(e => e.OrderStatusTypeId);

                entity.Property(e => e.AdjustmentCreatedBy).IsUnicode(false);

                entity.Property(e => e.AdjustmentUpdatedBy).IsUnicode(false);

                entity.Property(e => e.CurrencyTypeId).HasDefaultValueSql("((2))");

                entity.HasOne(d => d.CreditReasonType)
                    .WithMany(p => p.TOrderAdjustment)
                    .HasForeignKey(d => d.CreditReasonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCreditReasonType_tOrderAdjustment_FK");

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.TOrderAdjustment)
                    .HasForeignKey(d => d.CurrencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCurrencyType_tOrderAdjustment_FK");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TOrderAdjustment)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrder_tOrderAdjustment_FK");

                entity.HasOne(d => d.OrderStatusType)
                    .WithMany(p => p.TOrderAdjustment)
                    .HasForeignKey(d => d.OrderStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderStatusType_tOrderAdjustment_FK");
            });

            modelBuilder.Entity<TOrderAdjustmentError>(entity =>
            {
                entity.HasIndex(e => e.OrderAdjustmentId)
                    .HasName("tOrderAdjustment_tOrderAdjustmentError_NDX");

                entity.Property(e => e.OrderAdjustmentErrorCode).IsUnicode(false);

                entity.Property(e => e.OrderAdjustmentErrorCreatedBy).IsUnicode(false);

                entity.Property(e => e.OrderAdjustmentErrorDescription).IsUnicode(false);

                entity.HasOne(d => d.OrderAdjustment)
                    .WithMany(p => p.TOrderAdjustmentError)
                    .HasForeignKey(d => d.OrderAdjustmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderAdjustment_tOrderAdjustmentError_FK");
            });

            modelBuilder.Entity<TOrderAmountType>(entity =>
            {
                entity.Property(e => e.OrderAmountTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderAmountType).IsUnicode(false);
            });

            modelBuilder.Entity<TOrderCancelErrorType>(entity =>
            {
                entity.Property(e => e.OrderCancelErrorType).IsUnicode(false);
            });

            modelBuilder.Entity<TOrderCategoryCancel>(entity =>
            {
                entity.HasIndex(e => e.OrderCategoryCancelReasonId);

                entity.HasIndex(e => e.OrderCategoryKeyId);

                entity.Property(e => e.ConfirmationCode).IsUnicode(false);

                entity.Property(e => e.PointsRefunded).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProviderCancellationCode).IsUnicode(false);

                entity.Property(e => e.ProviderCancellationFee).HasDefaultValueSql("((0))");

                entity.Property(e => e.PurchasePriceRefunded).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.OrderCategoryCancelReason)
                    .WithMany(p => p.TOrderCategoryCancel)
                    .HasForeignKey(d => d.OrderCategoryCancelReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderCategoryCancel_tOrderCategoryCancelReason_OrderCategoryCancelReasonId_FK");

                entity.HasOne(d => d.OrderCategoryKey)
                    .WithMany(p => p.TOrderCategoryCancel)
                    .HasForeignKey(d => d.OrderCategoryKeyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderCategoryKey_tOrderCategoryCancel_OrderCategoryKeyID_FK");
            });

            modelBuilder.Entity<TOrderCategoryCancelError>(entity =>
            {
                entity.HasIndex(e => e.OrderCancelErrorTypeId);

                entity.HasIndex(e => e.OrderCategoryCancelId);

                entity.HasOne(d => d.OrderCancelErrorType)
                    .WithMany(p => p.TOrderCategoryCancelError)
                    .HasForeignKey(d => d.OrderCancelErrorTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderCategoryCancelError_tOrderCancelErrorType_FK");

                entity.HasOne(d => d.OrderCategoryCancel)
                    .WithMany(p => p.TOrderCategoryCancelError)
                    .HasForeignKey(d => d.OrderCategoryCancelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderCategoryCancelError_tOrderCategoryCancel_FK");
            });

            modelBuilder.Entity<TOrderCategoryCancelReason>(entity =>
            {
                entity.Property(e => e.OrderCategoryCancelReasonId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TOrderCategoryKey>(entity =>
            {
                entity.HasIndex(e => e.ActivityId);

                entity.HasIndex(e => e.AirTicketId);

                entity.HasIndex(e => e.CarRentalId);

                entity.HasIndex(e => e.CruiseId);

                entity.HasIndex(e => e.HotelRoomId);

                entity.HasIndex(e => e.PackageId);

                entity.HasIndex(e => e.RetailProductId);

                entity.HasIndex(e => new { e.CategoryId, e.OrderCategoryId })
                    .HasName("UIX_tOrderCategoryKey_CategoryID_OrderCategoryID")
                    .IsUnique();

                entity.Property(e => e.OrderCategoryId).HasComputedColumnSql("(coalesce([AirTicketID],[CarRentalID],[HotelRoomID],[CruiseID],[ActivityID],[PackageID],[RetailProductID]))");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TOrderCategoryKey)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("tOrderCategoryKey_tActivity_FK");

                entity.HasOne(d => d.AirTicket)
                    .WithMany(p => p.TOrderCategoryKey)
                    .HasForeignKey(d => d.AirTicketId)
                    .HasConstraintName("tOrderCategoryKey_tAirTicket_FK");

                entity.HasOne(d => d.CarRental)
                    .WithMany(p => p.TOrderCategoryKey)
                    .HasForeignKey(d => d.CarRentalId)
                    .HasConstraintName("tOrderCategoryKey_tCarRental_FK");

                entity.HasOne(d => d.Cruise)
                    .WithMany(p => p.TOrderCategoryKey)
                    .HasForeignKey(d => d.CruiseId)
                    .HasConstraintName("tOrderCategoryKey_tCruise_FK");

                entity.HasOne(d => d.HotelRoom)
                    .WithMany(p => p.TOrderCategoryKey)
                    .HasForeignKey(d => d.HotelRoomId)
                    .HasConstraintName("tOrderCategoryKey_tHotelRoom_FK");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.TOrderCategoryKey)
                    .HasForeignKey(d => d.PackageId)
                    .HasConstraintName("tOrderCategoryKey_tPackage_FK");

                entity.HasOne(d => d.RetailProduct)
                    .WithMany(p => p.TOrderCategoryKey)
                    .HasForeignKey(d => d.RetailProductId)
                    .HasConstraintName("tOrderCategoryKey_tRetailProduct_FK");
            });

            modelBuilder.Entity<TOrderCurrency>(entity =>
            {
                entity.HasIndex(e => new { e.OrderId, e.CurrencyTypeId, e.OrderCurrencyId })
                    .HasName("IXUC_tOrderID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.OrderId, e.OrderCurrencyAmount, e.OrderAmountTypeId })
                    .HasName("tOrderCurrency_IXNN_OrderAmountTypeID");

                entity.Property(e => e.OrderCurrencyAmount).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OrderCurrencyAmountForeignCurrency).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OrderCurrencyClientCatalogBonusCost).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OrderCurrencyClientCatalogBonusCostForeignCurrency).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OrderCurrencyClientCatalogCode).IsUnicode(false);

                entity.Property(e => e.OrderCurrencyExchangeRate).HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.TOrderCurrency)
                    .HasForeignKey(d => d.CurrencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCurrencyType_tOrderCurrency_FK");

                entity.HasOne(d => d.OrderAmountType)
                    .WithMany(p => p.TOrderCurrency)
                    .HasForeignKey(d => d.OrderAmountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderAmountType_tOrderCurrency_FK");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TOrderCurrency)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrder_tOrderCurrency_FK");
            });

            modelBuilder.Entity<TOrderDetail>(entity =>
            {
                entity.HasIndex(e => e.OrderId);

                entity.HasIndex(e => new { e.OrderDetailId, e.OrderCategoryId })
                    .HasName("NCI_tOrderDetail_CategoryID");

                entity.HasIndex(e => new { e.OrderDetailId, e.OrderId, e.OrderCategoryId });

                entity.HasIndex(e => new { e.OrderId, e.OrderDetailId, e.OrderCategoryId })
                    .HasName("IX_tOrderDetail_OrderID_OrderDetailID_OrderCategoryI");

                entity.Property(e => e.OrderDetailClientCode).IsUnicode(false);

                entity.Property(e => e.OrderDetailLastUpdatedBy).IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TOrderDetail)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrder_tOrderDetail_FK");
            });

            modelBuilder.Entity<TOrderDetailAmountType>(entity =>
            {
                entity.Property(e => e.OrderDetailAmountTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderDetailAmountType).IsUnicode(false);
            });

            modelBuilder.Entity<TOrderDetailConversion>(entity =>
            {
                entity.HasIndex(e => e.OrderDetailId)
                    .HasName("tOrderDetailConversion_IXNN_OrderDetailID");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TOrderDetailConversion)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tOrderDetailConversion_FK");
            });

            modelBuilder.Entity<TOrderDetailCurrency>(entity =>
            {
                entity.HasIndex(e => e.ActivityId)
                    .HasName("IX_tOrderCurrencyDetail_ActivityID");

                entity.HasIndex(e => e.AirTicketId);

                entity.HasIndex(e => e.CarRentalId);

                entity.HasIndex(e => e.CruiseId);

                entity.HasIndex(e => e.CurrencyTypeId)
                    .HasName("tOrderDetailCurrency_IXNN_CurrencyTypeID");

                entity.HasIndex(e => e.HotelRoomId);

                entity.HasIndex(e => e.OrderDetailCurrencyStatusId);

                entity.HasIndex(e => e.PackageId);

                entity.HasIndex(e => e.RetailProductId);

                entity.HasIndex(e => new { e.OrderDetailCurrencyCategoryUid, e.OrderDetailCurrencyId })
                    .HasName("tOrderDetailCurrency_IXNN_UID");

                entity.HasIndex(e => new { e.OrderDetailCurrencyCategoryUid, e.CurrencyTypeId, e.OrderDetailAmountTypeId });

                entity.HasIndex(e => new { e.OrderDetailCurrencyCategoryUid, e.CurrencyTypeId, e.OrderDetailCurrencyId })
                    .HasName("tOrderDetailCurrency_IXUC_ODCurrCatUIDCurrTypeIdODCurrID")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.HasIndex(e => new { e.OrderDetailCurrencyAmount, e.CurrencyTypeId, e.OrderDetailCurrencyCategoryUid, e.OrderDetailCurrencyId })
                    .HasName("tOrderDetailCurrency_IXUN_CurrTypeIdODCurCatUid");

                entity.HasIndex(e => new { e.ProgramCurrencyCashValue, e.CurrencyTypeId, e.OrderDetailCurrencyStatusId, e.CruiseId })
                    .HasName("IX_tOrderDetailCurrency_CurrencyTypeID_OrderDetailCurrencyStatusID_CruiseID_INCLUDES");

                entity.Property(e => e.ActivityId).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirTicketId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CarRentalId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CruiseId).HasDefaultValueSql("((0))");

                entity.Property(e => e.HotelRoomId).HasDefaultValueSql("((0))");

                entity.Property(e => e.MerchantRecoveryFee).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.MerchantRecoveryFeeForeignCurrency).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OrderDetailAmountTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.OrderDetailCurrencyAmountForeignCurrency).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.OrderDetailCurrencyExchangeRate).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.PackageId).HasDefaultValueSql("((0))");

                entity.Property(e => e.RetailProductId).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TOrderDetailCurrency)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tActivity_tOrderCurrencyDetail_FK");

                entity.HasOne(d => d.AirTicket)
                    .WithMany(p => p.TOrderDetailCurrency)
                    .HasForeignKey(d => d.AirTicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tAirTicket_tOrderCurrencyDetail_FK");

                entity.HasOne(d => d.CarRental)
                    .WithMany(p => p.TOrderDetailCurrency)
                    .HasForeignKey(d => d.CarRentalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCarRental_tOrderDetailCurrency_FK");

                entity.HasOne(d => d.Cruise)
                    .WithMany(p => p.TOrderDetailCurrency)
                    .HasForeignKey(d => d.CruiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCruise_tOrderCurrencyDetail_FK");

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.TOrderDetailCurrency)
                    .HasForeignKey(d => d.CurrencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCurrencyType_tOrderDetailCurrency_FK");

                entity.HasOne(d => d.HotelRoom)
                    .WithMany(p => p.TOrderDetailCurrency)
                    .HasForeignKey(d => d.HotelRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tHotelRoom_tOrderCurrencyDetail_FK");

                entity.HasOne(d => d.OrderDetailCurrencyStatus)
                    .WithMany(p => p.TOrderDetailCurrency)
                    .HasForeignKey(d => d.OrderDetailCurrencyStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetailCurrency_tOrderDetailCurrencyStatus_FK");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.TOrderDetailCurrency)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tPackage_tOrderCurrencyDetail_FK");

                entity.HasOne(d => d.RetailProduct)
                    .WithMany(p => p.TOrderDetailCurrency)
                    .HasForeignKey(d => d.RetailProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tRetailProduct_tOrderCurrencyDetail_FK");
            });

            modelBuilder.Entity<TOrderDetailCurrencyStatus>(entity =>
            {
                entity.Property(e => e.OrderDetailCurrencyStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderDetailCurrencyStatus).IsUnicode(false);
            });

            modelBuilder.Entity<TOrderDetailProviderLocator>(entity =>
            {
                entity.HasIndex(e => e.DetailLocator);

                entity.HasIndex(e => e.OrderDetailId)
                    .HasName("tProviderLocator_OrderDetailID");

                entity.HasIndex(e => e.ProviderLocatorId)
                    .HasName("tProviderLocator_tOrderDetailProviderLocator_NDX");

                entity.Property(e => e.DetailLocator).IsUnicode(false);

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TOrderDetailProviderLocator)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tOrderDetailProviderLocator_FK");

                entity.HasOne(d => d.ProviderLocator)
                    .WithMany(p => p.TOrderDetailProviderLocator)
                    .HasForeignKey(d => d.ProviderLocatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProviderLocator_tOrderDetailProviderLocator_FK");
            });

            modelBuilder.Entity<TOrderDetailTripProduct>(entity =>
            {
                entity.HasIndex(e => e.TripProductId)
                    .HasName("ix_tOrderDetailTripProduct_TripProductID");

                entity.Property(e => e.OrderDetailId).ValueGeneratedNever();

                entity.HasOne(d => d.OrderDetail)
                    .WithOne(p => p.TOrderDetailTripProduct)
                    .HasForeignKey<TOrderDetailTripProduct>(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tOrderDetailTripProduct_FK");
            });

            modelBuilder.Entity<TOrderError>(entity =>
            {
                entity.HasIndex(e => e.OrderDetailId)
                    .HasName("tOrderDetail_tOrderError_NDX");

                entity.Property(e => e.OrderErrorCode).IsUnicode(false);

                entity.Property(e => e.OrderErrorCreatedBy).IsUnicode(false);

                entity.Property(e => e.OrderErrorDescription).IsUnicode(false);

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TOrderError)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tOrderError_FK");
            });

            modelBuilder.Entity<TOrderNote>(entity =>
            {
                entity.HasIndex(e => e.OrderId)
                    .HasName("tOrderNote_OrderID_NDX");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.DispositionSessionId).IsUnicode(false);

                entity.Property(e => e.OrderNote).IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TOrderNote)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrder_tOrderNote_FK");

                entity.HasOne(d => d.OrderNoteCategory)
                    .WithMany(p => p.TOrderNote)
                    .HasForeignKey(d => d.OrderNoteCategoryId)
                    .HasConstraintName("FK_tOrderNote_tOrderNoteCategory");
            });

            modelBuilder.Entity<TOrderNoteCategory>(entity =>
            {
                entity.HasIndex(e => e.DisplayOrder);

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<TOrderParticipant>(entity =>
            {
                entity.HasIndex(e => new { e.OrderId, e.ParticipantCode })
                    .HasName("tOrderParticipant_IXNN_OrderIdParticipantCode");

                entity.HasIndex(e => new { e.ParticipantAdditionalId, e.ParticipantCode, e.OrderId })
                    .HasName("tOrderParticipant_IXNN_ParticipantCode");

                entity.HasIndex(e => new { e.ParticipantLastname, e.OrderId, e.ParticipantCode, e.ParticipantAdditionalId, e.ParticipantFirstName })
                    .HasName("tOrderParticipant_IXNN_ParticipantFirstName");

                entity.Property(e => e.ParticipantCode).IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TOrderParticipant)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrder_tOrderParticipant_FK");
            });

            modelBuilder.Entity<TOrderParticipantTax>(entity =>
            {
                entity.HasIndex(e => e.OrderId);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TOrderParticipantTax)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrder_tOrderParticipantTax_FK");
            });

            modelBuilder.Entity<TOrderProviderLocator>(entity =>
            {
                entity.HasIndex(e => e.OrderId)
                    .HasName("tOrder_tOrderProviderLocator_NDX");

                entity.HasIndex(e => e.OrderLocator);

                entity.HasIndex(e => e.ProviderLocatorId)
                    .HasName("tProviderLocator_tOrderProviderLocator_NDX");

                entity.Property(e => e.OrderLocator).IsUnicode(false);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TOrderProviderLocator)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrder_tOrderProviderLocator_FK");

                entity.HasOne(d => d.ProviderLocator)
                    .WithMany(p => p.TOrderProviderLocator)
                    .HasForeignKey(d => d.ProviderLocatorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProviderLocator_tOrderProviderLocator_FK");
            });

            modelBuilder.Entity<TOrderRefundFailure>(entity =>
            {
                entity.HasIndex(e => e.OrderId);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.TOrderRefundFailure)
                    .HasForeignKey(d => d.CurrencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tOrderRefundFailure_tCurrencyType");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TOrderRefundFailure)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tOrderRefundFailure_tOrder");
            });

            modelBuilder.Entity<TOrderRefundFailureDetail>(entity =>
            {
                entity.HasKey(e => new { e.OrderRefundFailureId, e.CategoryCancelDetailId });

                entity.HasOne(d => d.CategoryCancelDetail)
                    .WithMany(p => p.TOrderRefundFailureDetail)
                    .HasForeignKey(d => d.CategoryCancelDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tOrderRefundFailureDetail_tCategoryCancelDetail");

                entity.HasOne(d => d.OrderRefundFailure)
                    .WithMany(p => p.TOrderRefundFailureDetail)
                    .HasForeignKey(d => d.OrderRefundFailureId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tOrderRefundFailureDetail_tOrderRefundFailure");
            });

            modelBuilder.Entity<TOrderStatusType>(entity =>
            {
                entity.Property(e => e.OrderStatusType).IsUnicode(false);
            });

            modelBuilder.Entity<TOrderStatusTypeCulture>(entity =>
            {
                entity.HasIndex(e => e.OrderStatusTypeId);

                entity.HasOne(d => d.OrderStatusType)
                    .WithMany(p => p.TOrderStatusTypeCulture)
                    .HasForeignKey(d => d.OrderStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderStatusType_tOrderStatusTypeCulture_FK");
            });

            modelBuilder.Entity<TOrderTripFolder>(entity =>
            {
                entity.HasIndex(e => e.TripFolderId)
                    .HasName("ix_tOrderTripFolder_TripFolderID");

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.HasOne(d => d.Order)
                    .WithOne(p => p.TOrderTripFolder)
                    .HasForeignKey<TOrderTripFolder>(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrder_tOrderTripFolder_FK");
            });

            modelBuilder.Entity<TOrderType>(entity =>
            {
                entity.Property(e => e.OrderTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.OrderType).IsUnicode(false);
            });

            modelBuilder.Entity<TPackage>(entity =>
            {
                entity.HasIndex(e => e.CreditReasonTypeId);

                entity.HasIndex(e => e.OrderDetailId);

                entity.HasIndex(e => e.OrderStatusTypeId);

                entity.HasIndex(e => new { e.OrderDetailId, e.OrderStatusTypeId, e.CreditReasonTypeId })
                    .HasName("tPackageIDs_NDX");

                entity.HasIndex(e => new { e.PackageId, e.OrderDetailId, e.PackageFirstName })
                    .HasName("IX_Package_PackageFirstName");

                entity.HasIndex(e => new { e.PackageCurrencyDescription, e.OrderDetailId, e.PackageId, e.PackageUid })
                    .HasName("NCI_tPackage_OrderDetailID_ID_UID");

                entity.Property(e => e.CreditReasonTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageClientCatalogCode).IsUnicode(false);

                entity.Property(e => e.PackageConfirmationCode).IsUnicode(false);

                entity.Property(e => e.PackageCurrencyDescription).IsUnicode(false);

                entity.Property(e => e.PackageLastUpdatedBy).IsUnicode(false);

                entity.HasOne(d => d.CreditReasonType)
                    .WithMany(p => p.TPackage)
                    .HasForeignKey(d => d.CreditReasonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCreditReasonType_tPackage_FK");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TPackage)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tPackage_FK");

                entity.HasOne(d => d.OrderStatusType)
                    .WithMany(p => p.TPackage)
                    .HasForeignKey(d => d.OrderStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderStatusType_tPackage_FK");
            });

            modelBuilder.Entity<TParticipantCustomClientField>(entity =>
            {
                entity.HasIndex(e => e.OrderParticipantId)
                    .HasName("IX_tParticipantCustomClientField_OrderParticipantID2");

                entity.HasIndex(e => new { e.OrderParticipantId, e.ParticipantCustomClientFieldId })
                    .HasName("IXUC_OrderParticipantID2")
                    .IsUnique();

                entity.HasIndex(e => new { e.ParticipantCustomFieldValue, e.OrderParticipantId, e.ParticipantCustomFieldName })
                    .HasName("IX_OrderParticipantID_ParticipantCustomFieldName_w_ParticipantCustomFieldValue_Filter_AccountReferenceNumber")
                    .HasFilter("([ParticipantCustomFieldName]='AccountReferenceNumber')");

                entity.HasOne(d => d.OrderParticipant)
                    .WithMany(p => p.TParticipantCustomClientField)
                    .HasForeignKey(d => d.OrderParticipantId)
                    .HasConstraintName("FK_tOrderParticipant_tParticipantCustomClientField");
            });

            modelBuilder.Entity<TPrimaryCruiseDestination>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("IX_tPrimaryCruiseDestination");

                entity.HasIndex(e => e.Name)
                    .HasName("UK_tPrimaryCruiseDestination_Name")
                    .IsUnique();

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<TPromotions>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExternalPromotionId).IsUnicode(false);

                entity.Property(e => e.ExternalPromotionTermsId).IsUnicode(false);

                entity.Property(e => e.PromotionDescription).IsUnicode(false);

                entity.HasOne(d => d.Cruise)
                    .WithMany(p => p.TPromotions)
                    .HasForeignKey(d => d.CruiseId)
                    .HasConstraintName("tPromotions_tCruise_FK");

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.TPromotions)
                    .HasForeignKey(d => d.CurrencyTypeId)
                    .HasConstraintName("tPromotions_tCurrencyType_FK");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TPromotions)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("tPromotions_tProvider_FK");
            });

            modelBuilder.Entity<TProvider>(entity =>
            {
                entity.HasIndex(e => e.OrderTypeId);

                entity.HasIndex(e => e.ProviderTypeId)
                    .HasName("tProviderType_tProvider_NDX");

                entity.Property(e => e.AccountingSupplierId).IsUnicode(false);

                entity.Property(e => e.OrderTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProviderUrl).IsUnicode(false);

                entity.Property(e => e.VendorSupplierId).IsUnicode(false);

                entity.HasOne(d => d.OrderType)
                    .WithMany(p => p.TProvider)
                    .HasForeignKey(d => d.OrderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderType_tProvider_OrderTypeID_FK");

                entity.HasOne(d => d.ProviderType)
                    .WithMany(p => p.TProvider)
                    .HasForeignKey(d => d.ProviderTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProviderType_tProvider_FK");
            });

            modelBuilder.Entity<TProviderCancelPolicy>(entity =>
            {
                entity.HasIndex(e => e.ProviderId);

                entity.Property(e => e.CancelFeeForeignCurrency).HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TProviderCancelPolicy)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProvider_tProviderCancelPolicy_ProviderID_FK");
            });

            modelBuilder.Entity<TProviderCancelPolicyProviderCancelPolicyText>(entity =>
            {
                entity.HasIndex(e => e.ProviderCancelPolicyTextId);

                entity.HasIndex(e => new { e.ProviderCancelPolicyId, e.ProviderCancelPolicyTextId })
                    .HasName("UIX_tProviderCancelPolicyProviderCancelPolicyText")
                    .IsUnique();

                entity.HasOne(d => d.ProviderCancelPolicy)
                    .WithMany(p => p.TProviderCancelPolicyProviderCancelPolicyText)
                    .HasForeignKey(d => d.ProviderCancelPolicyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProviderCancelPolicyProviderCancelPolicyText_tProviderCancelPolicy_FK");

                entity.HasOne(d => d.ProviderCancelPolicyText)
                    .WithMany(p => p.TProviderCancelPolicyProviderCancelPolicyText)
                    .HasForeignKey(d => d.ProviderCancelPolicyTextId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProviderCancelPolicyProviderCancelPolicyText_tProviderCancelPolicyText_FK");
            });

            modelBuilder.Entity<TProviderCancelPolicyTextCulture>(entity =>
            {
                entity.HasKey(e => new { e.ProviderCancelPolicyTextCultureId, e.ProviderCancelPolicyTextId });

                entity.HasIndex(e => e.ProviderCancelPolicyTextId);

                entity.Property(e => e.ProviderCancelPolicyTextCultureId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.ProviderCancelPolicyText)
                    .WithMany(p => p.TProviderCancelPolicyTextCulture)
                    .HasForeignKey(d => d.ProviderCancelPolicyTextId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProviderCancelPolicyText_tProviderCancelPolicyTextCulture_FK");
            });

            modelBuilder.Entity<TProviderCategory>(entity =>
            {
                entity.HasIndex(e => new { e.ProviderId, e.CategoryId })
                    .HasName("tProviderCategory_ProviderID_CategoryID_UDX")
                    .IsUnique();

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TProviderCategory)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProvider_tProviderCategory_FK");
            });

            modelBuilder.Entity<TProviderCulture>(entity =>
            {
                entity.HasIndex(e => e.ProviderId);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TProviderCulture)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProvider_tProviderCulture_FK");
            });

            modelBuilder.Entity<TProviderLocator>(entity =>
            {
                entity.HasIndex(e => e.ProviderId)
                    .HasName("tProvider_tProviderLocator_NDX");

                entity.HasIndex(e => e.ProviderLocatorTypeId)
                    .HasName("tProviderLocatorType_tProviderLocator_NDX");

                entity.HasIndex(e => new { e.ProviderLocatorId, e.ProviderId })
                    .HasName("tProviderLocator_NDX1");

                entity.HasIndex(e => new { e.ProviderLocatorId, e.ProviderId, e.ProviderLocatorTypeId })
                    .HasName("IX_tProviderLocator_ProviderLocatorTypeID_ProviderLocatorID_ProviderID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TProviderLocator)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProvider_tProviderLocator_FK");

                entity.HasOne(d => d.ProviderLocatorType)
                    .WithMany(p => p.TProviderLocator)
                    .HasForeignKey(d => d.ProviderLocatorTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProviderLocatorType_tProviderLocator_FK");
            });

            modelBuilder.Entity<TProviderLocatorType>(entity =>
            {
                entity.Property(e => e.ProviderLocatorType).IsUnicode(false);
            });

            modelBuilder.Entity<TProviderType>(entity =>
            {
                entity.Property(e => e.ProviderType).IsUnicode(false);
            });

            modelBuilder.Entity<TRetailProduct>(entity =>
            {
                entity.HasIndex(e => e.CreditReasonTypeId);

                entity.HasIndex(e => e.OrderDetailId);

                entity.HasIndex(e => e.OrderStatusTypeId);

                entity.HasIndex(e => e.RetailProductUid)
                    .HasName("tRetailProductUID_UDX")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrderDetailId, e.OrderStatusTypeId, e.CreditReasonTypeId })
                    .HasName("tRetailProductIDs_NDX");

                entity.HasIndex(e => new { e.RetailProductId, e.OrderDetailId, e.RetailProductFirstName })
                    .HasName("IX_RetailProduct_RetailProductFirstName");

                entity.HasIndex(e => new { e.RetailProductCurrencyDescription, e.OrderDetailId, e.RetailProductId, e.RetailProductUid })
                    .HasName("NCI_tRetailProduct_OrderDetailID_ID_UID");

                entity.Property(e => e.CreditReasonTypeId).HasDefaultValueSql("((0))");

                entity.Property(e => e.RetailProductClientCatalogCode).IsUnicode(false);

                entity.Property(e => e.RetailProductConfirmationCode).IsUnicode(false);

                entity.Property(e => e.RetailProductCurrencyDescription).IsUnicode(false);

                entity.Property(e => e.RetailProductLastUpdatedBy).IsUnicode(false);

                entity.HasOne(d => d.CreditReasonType)
                    .WithMany(p => p.TRetailProduct)
                    .HasForeignKey(d => d.CreditReasonTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCreditReasonType_tRetailProduct_FK");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TRetailProduct)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tRetailProduct_FK");

                entity.HasOne(d => d.OrderStatusType)
                    .WithMany(p => p.TRetailProduct)
                    .HasForeignKey(d => d.OrderStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderStatusType_tRetailProduct_FK");
            });

            modelBuilder.Entity<TRuleGroupRegisterDetail>(entity =>
            {
                entity.HasIndex(e => e.OrderDetailId);

                entity.HasIndex(e => e.OrderParticipantId);

                entity.HasIndex(e => e.RuleGroupRegisterId);

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TRuleGroupRegisterDetail)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tRuleGroupRegisterDetail_FK");

                entity.HasOne(d => d.OrderParticipant)
                    .WithMany(p => p.TRuleGroupRegisterDetail)
                    .HasForeignKey(d => d.OrderParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderParticipant_tRuleGroupRegisterDetail_FK");
            });

            modelBuilder.Entity<TShipping>(entity =>
            {
                entity.HasIndex(e => e.ActivityId);

                entity.HasIndex(e => e.AirTicketId);

                entity.HasIndex(e => e.CarRentalId);

                entity.HasIndex(e => e.CruiseId);

                entity.HasIndex(e => e.HotelRoomId);

                entity.HasIndex(e => e.PackageId);

                entity.HasIndex(e => e.ProviderId);

                entity.HasIndex(e => e.RetailProductId);

                entity.HasIndex(e => e.ShippingStatusTypeId);

                entity.Property(e => e.ActivityId).HasDefaultValueSql("((0))");

                entity.Property(e => e.AirTicketId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CarRentalId).HasDefaultValueSql("((0))");

                entity.Property(e => e.CruiseId).HasDefaultValueSql("((0))");

                entity.Property(e => e.HotelRoomId).HasDefaultValueSql("((0))");

                entity.Property(e => e.PackageId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProviderId).HasDefaultValueSql("((0))");

                entity.Property(e => e.RetailProductId).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShippingSku).IsUnicode(false);

                entity.Property(e => e.ShippingTrackingCode).IsUnicode(false);

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.TShipping)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tActivity_tShipping_FK");

                entity.HasOne(d => d.AirTicket)
                    .WithMany(p => p.TShipping)
                    .HasForeignKey(d => d.AirTicketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tAirTicket_tShipping_FK");

                entity.HasOne(d => d.CarRental)
                    .WithMany(p => p.TShipping)
                    .HasForeignKey(d => d.CarRentalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCarRental_tShipping_FK");

                entity.HasOne(d => d.Cruise)
                    .WithMany(p => p.TShipping)
                    .HasForeignKey(d => d.CruiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tCruise_tShipping_FK");

                entity.HasOne(d => d.HotelRoom)
                    .WithMany(p => p.TShipping)
                    .HasForeignKey(d => d.HotelRoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tHotelRoom_tShipping_FK");

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.TShipping)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tPackage_tShipping_FK");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.TShipping)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tProvider_tShipping_FK");

                entity.HasOne(d => d.RetailProduct)
                    .WithMany(p => p.TShipping)
                    .HasForeignKey(d => d.RetailProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tRetailProduct_tShipping_FK");

                entity.HasOne(d => d.ShippingStatusType)
                    .WithMany(p => p.TShipping)
                    .HasForeignKey(d => d.ShippingStatusTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tShippingStatusType_tShipping_FK");
            });

            modelBuilder.Entity<TShippingStatusType>(entity =>
            {
                entity.Property(e => e.ShippingStatusType).IsUnicode(false);
            });

            modelBuilder.Entity<TSingleUseCard>(entity =>
            {
                entity.HasIndex(e => e.OrderDetailId);

                entity.Property(e => e.SingleUseCardAmount).HasDefaultValueSql("((0.00))");

                entity.Property(e => e.SingleUseCardAmountForeignCurrency).HasDefaultValueSql("((0.00))");

                entity.HasOne(d => d.OrderDetail)
                    .WithMany(p => p.TSingleUseCard)
                    .HasForeignKey(d => d.OrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tOrderDetail_tSingleUseCard_FK");
            });

            modelBuilder.Entity<ZQueueLog>(entity =>
            {
                entity.Property(e => e.Dt).HasDefaultValueSql("(getdate())");
            });
        }
    }
}
