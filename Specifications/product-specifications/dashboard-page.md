# Application Page: Dashboard

**Purpose**: Serves as the primary interface for managing immediate shopping needs and planning store visits based on product availability.

The Dashboard provides users with a streamlined workflow for adding products to their shopping list and determining the most efficient stores to visit based on product availability coverage.

## Tests
1. **Product Selection Component**: The top component on the Dashboard enables the user to select products from their master list and specify quantities that need to be purchased, without requiring store selection.

2. **Shopping Needs Display**: The main component displays a table showing all products currently needed for purchase, with each product row indicating availability status (available/unavailable) across all tracked stores. This is a core feature.

3. **Store Coverage Analysis**: The shopping needs table includes a footer row that shows for each store what percentage of needed products are available, helping users identify the most efficient shopping destinations. This is a core feature.

4. **Quantity Management**: Users can adjust the quantity of needed items directly in the shopping needs table using increment/decrement controls without navigating to separate forms.

5. **Purchase Completion**: Users can mark individual items as purchased or use a bulk action to clear all purchased items from their active shopping list.

6. **Quick Navigation**: The Dashboard provides direct links to the Products and Admin pages for managing the underlying data when the current inventory is insufficient.
