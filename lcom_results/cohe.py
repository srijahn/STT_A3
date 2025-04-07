import pandas as pd

csv_file = "TypeMetrics.csv"
df = pd.read_csv(csv_file, sep=",") 

df.columns = df.columns.str.strip()

# Ensure required columns exist
required_columns = {"Project Name", "Package Name", "Type Name", "LCOM1", "LCOM2", "LCOM3", "LCOM4", "LCOM5", "YALCOM"}
if not required_columns.issubset(df.columns):
    print(f"Error: Missing required columns. Available columns: {df.columns}")
else:
    # Select required columns
    cohesion_data = df[
        ["Type Name", "LCOM1", "LCOM2", "LCOM3", "LCOM4", "LCOM5", "YALCOM"]
    ]

    # Print table format
    print("\n **Cohesion Analysis Table** \n")
    print(cohesion_data.to_string(index=False))
