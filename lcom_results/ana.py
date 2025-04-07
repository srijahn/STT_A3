import pandas as pd

# Load the CSV file with the correct separator
csv_file = "TypeMetrics.csv"
df = pd.read_csv(csv_file, sep=",") 

# Debugging: Print column names again
print("Column names after fixing:", df.columns)

# Strip any leading/trailing spaces from column names
df.columns = df.columns.str.strip()

# Define thresholds for "High LCOM" 
LCOM1_THRESHOLD = 50
LCOM2_THRESHOLD = 40

# Ensure columns exist before filtering
required_columns = {"LCOM1", "LCOM2"}
if not required_columns.issubset(df.columns):
    print(f"Error: Missing required columns. Available columns: {df.columns}")
else:
    # Filter classes with high LCOM values
    high_lcom_classes = df[(df["LCOM1"] > LCOM1_THRESHOLD) | (df["LCOM2"] > LCOM2_THRESHOLD)]

    # Create a cohesion table with selected columns
    cohesion_table = high_lcom_classes[["Project Name", "Package Name", "Type Name", "LCOM1", "LCOM2", "LCOM3", "LCOM4", "LCOM5", "YALCOM"]]

    # Save the table to a new CSV file
    output_file = "HighLCOMClasses.csv"
    cohesion_table.to_csv(output_file, index=False)

    # Print the results
    print("\nHigh LCOM Classes Identified:")
    print(cohesion_table)
    print(f"\nCohesion table saved to {output_file}")

