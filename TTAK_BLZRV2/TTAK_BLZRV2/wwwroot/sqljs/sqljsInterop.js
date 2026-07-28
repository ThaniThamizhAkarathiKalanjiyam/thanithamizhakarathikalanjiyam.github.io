window.sqliteJs = {
    init: async () => {
        try {
            console.log("sqliteJs.init: Starting initialization...");
            if (window.SQL) {
                console.log("sqliteJs.init: Already initialized");
                return true;
            }

            console.log("sqliteJs.init: Loading sql-wasm.js...");
            await new Promise((resolve, reject) => {
                const s = document.createElement("script");
                s.src = "/sqljs/sql-wasm.js";
                s.onload = () => {
                    console.log("sqliteJs.init: sql-wasm.js loaded successfully");
                    resolve();
                };
                s.onerror = (e) => {
                    console.error("sqliteJs.init: Failed to load sql-wasm.js", e);
                    reject(e);
                };
                document.head.appendChild(s);
            });

            console.log("sqliteJs.init: Initializing SQL.js...");
            window.SQL = await initSqlJs({
                locateFile: f => {
                    console.log("sqliteJs.init: Locating file:", f);
                    return "/sqljs/" + f;
                }
            });

            window._dbs = {};
            console.log("sqliteJs.init: Initialization complete");
            return true;
        } catch (error) {
            console.error("sqliteJs.init: Error during initialization", error);
            throw error;
        }
    },

    openDb: (bytes) => {
        try {
            console.log("sqliteJs.openDb: Opening database, bytes:", bytes ? bytes.length : 0);
            const db = bytes ? new SQL.Database(new Uint8Array(bytes))
                : new SQL.Database();
            const id = crypto.randomUUID();
            window._dbs[id] = db;
            console.log("sqliteJs.openDb: Database opened with ID:", id);
            return id;
        } catch (error) {
            console.error("sqliteJs.openDb: Error opening database", error);
            throw error;
        }
    },

    exec: (id, sql, params) => {
        try {
            console.log("sqliteJs.exec: Executing query", { id, sql, params });
            const db = window._dbs[id];
            if (!db) {
                throw new Error("Database not found: " + id);
            }
            const stmt = db.prepare(sql);
            if (params) stmt.bind(params);
            const rows = [];
            while (stmt.step()) rows.push(stmt.getAsObject());
            stmt.free();
            console.log("sqliteJs.exec: Query returned", rows.length, "rows");
            return rows;
        } catch (error) {
            console.error("sqliteJs.exec: Error executing query", error);
            throw error;
        }
    },

    export: (id) => {
        try {
            console.log("sqliteJs.export: Exporting database", id);
            return window._dbs[id].export();
        } catch (error) {
            console.error("sqliteJs.export: Error exporting database", error);
            throw error;
        }
    },

    close: (id) => {
        try {
            console.log("sqliteJs.close: Closing database", id);
            window._dbs[id].close();
            delete window._dbs[id];
        } catch (error) {
            console.error("sqliteJs.close: Error closing database", error);
            throw error;
        }
    }
};