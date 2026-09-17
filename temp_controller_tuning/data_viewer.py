import tkinter as tk
from tkinter import filedialog, messagebox, ttk
import pandas as pd
import matplotlib.pyplot as plt
from matplotlib.backends.backend_tkagg import FigureCanvasTkAgg


class TemperatureCSVViewer:
    def __init__(self, root):
        self.root = root
        self.root.title("Temperature CSV Viewer")
        self.root.geometry("1100x700")

        self.df = None

        # Top control frame
        control_frame = ttk.Frame(root)
        control_frame.pack(fill="x", padx=10, pady=10)

        ttk.Button(
            control_frame,
            text="Open CSV File",
            command=self.open_csv
        ).pack(side="left", padx=5)

        ttk.Button(
            control_frame,
            text="Plot Data",
            command=self.plot_data
        ).pack(side="left", padx=5)

        ttk.Button(
            control_frame,
            text="Save Plot",
            command=self.save_plot
        ).pack(side="left", padx=5)

        self.file_label = ttk.Label(
            control_frame,
            text="No file loaded"
        )
        self.file_label.pack(side="left", padx=15)

        # Main notebook
        notebook = ttk.Notebook(root)
        notebook.pack(fill="both", expand=True)

        # Table tab
        table_frame = ttk.Frame(notebook)
        notebook.add(table_frame, text="Data Table")

        # Treeview table
        self.tree = ttk.Treeview(table_frame, show="headings")

        y_scroll = ttk.Scrollbar(
            table_frame,
            orient="vertical",
            command=self.tree.yview
        )

        x_scroll = ttk.Scrollbar(
            table_frame,
            orient="horizontal",
            command=self.tree.xview
        )

        self.tree.configure(
            yscrollcommand=y_scroll.set,
            xscrollcommand=x_scroll.set
        )

        self.tree.pack(side="left", fill="both", expand=True)
        y_scroll.pack(side="right", fill="y")
        x_scroll.pack(side="bottom", fill="x")

        # Plot tab
        plot_frame = ttk.Frame(notebook)
        notebook.add(plot_frame, text="Temperature Plot")

        self.figure, self.ax = plt.subplots(figsize=(10, 5))
        self.canvas = FigureCanvasTkAgg(
            self.figure,
            master=plot_frame
        )

        self.canvas.get_tk_widget().pack(
            fill="both",
            expand=True
        )

    def open_csv(self):
        file_path = filedialog.askopenfilename(
            title="Select CSV File",
            filetypes=[
                ("CSV Files", "*.csv"),
                ("All Files", "*.*")
            ]
        )

        if not file_path:
            return

        try:
            self.df = pd.read_csv(file_path)

            self.file_label.config(
                text=file_path.split("/")[-1]
            )

            self.display_table()
            self.plot_data()

        except Exception as e:
            messagebox.showerror(
                "Error",
                f"Could not open CSV file:\n{e}"
            )

    def display_table(self):
        # Clear existing table
        for item in self.tree.get_children():
            self.tree.delete(item)

        # Set columns
        self.tree["columns"] = list(self.df.columns)

        for column in self.df.columns:
            self.tree.heading(column, text=column)
            self.tree.column(column, width=180, anchor="center")

        # Insert rows
        for _, row in self.df.iterrows():
            self.tree.insert(
                "",
                "end",
                values=list(row)
            )

    def plot_data(self):
        if self.df is None:
            messagebox.showwarning(
                "Warning",
                "Please open a CSV file first."
            )
            return

        self.ax.clear()

        # Expected column names
        time_col = "Time (s)"
        actual_col = "Actual Temperature (C)"
        target_col = "Target Temperature (C)"

        if not all(
            col in self.df.columns
            for col in [time_col, actual_col, target_col]
        ):
            messagebox.showerror(
                "Error",
                "CSV does not contain the expected columns:\n"
                "Time (s), Actual Temperature (C), "
                "Target Temperature (C)"
            )
            return

        self.ax.plot(
            self.df[time_col],
            self.df[actual_col],
            label="Actual Temperature"
        )

        self.ax.plot(
            self.df[time_col],
            self.df[target_col],
            linestyle="--",
            label="Target Temperature"
        )

        self.ax.set_title("Temperature Response")
        self.ax.set_xlabel("Time (s)")
        self.ax.set_ylabel("Temperature (°C)")

        self.ax.grid(True)
        self.ax.legend()

        self.figure.tight_layout()
        self.canvas.draw()

    def save_plot(self):
        if self.df is None:
            messagebox.showwarning(
                "Warning",
                "Please open a CSV file first."
            )
            return

        save_path = filedialog.asksaveasfilename(
            title="Save Plot",
            defaultextension=".png",
            filetypes=[
                ("PNG Image", "*.png"),
                ("PDF File", "*.pdf"),
                ("SVG File", "*.svg")
            ]
        )

        if save_path:
            self.figure.savefig(
                save_path,
                dpi=300,
                bbox_inches="tight"
            )

            messagebox.showinfo(
                "Saved",
                f"Plot saved to:\n{save_path}"
            )


if __name__ == "__main__":
    root = tk.Tk()
    app = TemperatureCSVViewer(root)
    root.mainloop()
