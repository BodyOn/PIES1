pipeline {
  agent any
  stages {
    stage('Mensagem') {
      steps {
        echo 'Gerando emails'
        mail(subject: '[CI/CD] Execução da pipeline ', body: 'Pipeline sendo executada para geração de relatórios', charset: 'UTF-8', to: 'ewaldoj18@gmail.com, marianaoliveirafernandes11@gmail.com, jejosu346@gmail.com')
        echo 'Emails enviados com sucesso'
      }
    }

  }
}