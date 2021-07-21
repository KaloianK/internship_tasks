import Head from 'next/head'
import Link from 'next/link'
import styles from '../styles/Home.module.css'

export default function Home() {
  return (
    <div className={styles.container}>
      <Head>
        <title>Modulus POC</title>
        <meta name="description" content="Modulus POC app" />
        <link rel="icon" href="/modulus.png" />
      </Head>

      <main className={styles.main}>
        <h1 className={styles.title}>
          Welcome to Modulus POC
        </h1>

        <div className={styles.grid}>
          <Link href={"/ssr"} >
            <a className={styles.card}>
              <h2>SSR &rarr;</h2>
              <p>Server side rendering example.</p>
            </a>
          </Link>

          <Link href={"/csr"}>
            <a className={styles.card}>
              <h2>CSR &rarr;</h2>
              <p>Client side rendering example!</p>
            </a>
          </Link>

          <Link href={"/componentsLib/treePicker"}>
            <a className={styles.card}>
              <h2>Tree Picker &rarr;</h2>
              <p>Tree picker component</p>
            </a>
          </Link>
        </div>
      </main>
      <footer className={styles.footer}>
      </footer>
    </div>
  )
}